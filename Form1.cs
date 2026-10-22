
using System.Text.Json;

///<summary>
///this is where the magic happens!
///a bunch of events that handle button pressing and stuff.
/// </summary>

namespace Nordic_Real_Estates___Version_2
{
    public partial class Form1 : Form
    {
        private readonly EstateManager estateManager = new EstateManager(); //give the form ONE manager to manage all estates.
        private readonly List<int> estateIndexes = new List<int>(); //list to store indexes of each estate (for add, remove & modify purposes)
        private int selectedEstateIndex = -1; //index of currently selected estate.
        private int editingEstateIndex = -1;

        private readonly string filePath = Path.Combine(AppContext.BaseDirectory, "estateData.json"); //file path for json file. should be within the project repo.


        public Form1()
        {
            InitializeComponent(); //initialize component

            this.FormClosing += Form1_FormClosing; //event for saving estates when closing the form.

            cmbCountry.DataSource = Enum.GetValues<Countries>(); //populate country combobox with enum values from Countries class.

            InitializeDataFile(); //initialize data file, this either initializes an existing file, or creates a new file if it doesn't exist..
            LoadEstates(); //load saved estates (if none are loaded the listbox will still be empty).
        }

        private void Form1_Load(object sender, EventArgs e) //eh
        {

        }

        private void menuSchool_Click(object sender, EventArgs e) //text box showing selected estate. it swithces depending on the currently selected estate.
        {
            txtEstateSelected.Text = "School"; //school!
            UpdateEstateFields("School");
        }

        private void menuShop_Click(object sender, EventArgs e) //text box showing selected estate. it swithces depending on the currently selected estate.
        {
            txtEstateSelected.Text = "Shop"; //shop!
            UpdateEstateFields("Shop");
        }

        private void menuVilla_Click(object sender, EventArgs e) //text box showing selected estate. it swithces depending on the currently selected estate.
        {
            txtEstateSelected.Text = "Villa"; //villa!
            UpdateEstateFields("Villa");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            estateCategories.Show(btnEstateType, 0, btnEstateType.Height); //event for selecting estate category with a menu with further drop down to select
            //estate type --> villa/shop/school depending on type.
        }

        private void UpdateEstateFields(string estateType) //display group box depending on which estatetype (category) is selected. 
        {
            grpVilla.Visible = estateType == "Villa"; //display villa group box if estateType is villa, otherwise hide it.
            grpShop.Visible = estateType == "Shop"; //--||--
            grpSchool.Visible = estateType == "School"; //--||--
        }

        private void lblEstates_Click(object sender, EventArgs e) //ye
        {

        }

        private void btnAddEstate_Click(object sender, EventArgs e) //adds an estate to listbox!
        {
            Estate estate = CreateEstateFromInputs(); //creates an estate based on the inputs from estate planner display!

            if (estate != null) //once estate is created and isn't null, the estatemanager will add the estate to a list and update listbox display!
            {
                estateManager.Add(estate);
                UpdateEstateList();
            }
        }

        private void btnModifyEstate_Click(object sender, EventArgs e) //method to modify a selected estate!
        {
            if (selectedEstateIndex == -1) //if no estate is selected
            {
                MessageBox.Show("Please select an estate to modify.");
                return;
            }

            editingEstateIndex = selectedEstateIndex; //editingEstateIndex is used to temporarily store the index of the estate we are modifying.
            //if i don't use editingEstateIndex the "apply" method might mess up if the index of an estate is changed while we are modifying it.
            //this happens because in lstEstate_SelectedIndexChanged updates the selected index when we press any line in the estates listbox.

            Estate estate = estateManager.GetAt(editingEstateIndex); //we use editingEstateIndex to get temporarily store the index of the estate we want to modify.
            DisplayEstate(estate); //then change the estate planner's display to the selected estates information so it can be modified.
        }

        private void btnDelEstate_Click(object sender, EventArgs e) //method to delete an estate.
        {
            Console.WriteLine("attempting to remove estate");

            if (selectedEstateIndex == -1) //as long as index is valid.
            {
                MessageBox.Show("Please select an estate to remove.");
                return;
            }

            estateManager.RemoveAt(selectedEstateIndex);
            selectedEstateIndex = -1; //reset selected index
            editingEstateIndex = -1; //reset the temporary editing index aswell, just in case.
            UpdateEstateList(); //update the estates in the listbox.
        }

        private void btnApplyChanges_Click(object sender, EventArgs e) //method to apply modifications to current 
        {
            //this method has the most use for editingEstateIndex, as it is used to temporarily store the index of the estate we are modifying.
            //its already stated elsewhere in the code but the reason was that once the modify button is pressed i wanted to prevent the selectedEstateIndex
            //from changing what estate we are trying to modify by accidentally pressing a different index in the listbox for example.
            //i also didnt want to disable components in the GUI for this purpose, so the variable seemed very fitting.

            if (editingEstateIndex == -1)
            {
                MessageBox.Show("You are not modifying an estate.");
                return;
            }

            Estate updatedEstate = CreateEstateFromInputs(); //create a new estate based on inputs and replace the old estate on the corresponding index :)
            //surprising test result is that when clicking modify, you can also change the category and essentially turn one estate type into another estate type
            //a villa could become a shop or a school. which is a fine feature i think. would be prevented by disabling the menu list during modification.

            if (updatedEstate != null) //if the updated estate is valid.
            {
                estateManager.ChangeAt(editingEstateIndex, updatedEstate); //access the estateManagers ChangeAt method to replace the old estate with new modified one.

                UpdateEstateList(); //update estate listbox display.
            }

            editingEstateIndex = -1; //reset selected index so we don't cause any problems!
        }

        private void btnSave_Click(object sender, EventArgs e) //method to call saving estates to a .json file
        {
            SaveEstates();
        }

        private void lstEstates_SelectedIndexChanged(object sender, EventArgs e) //handles any selection changes in the listbox that displays all estates.
        {
            int selectedRow = lstEstates.SelectedIndex; //get index of listbox which will equal the selected row

            if (selectedRow == -1) //if index is invalid pretty much
            {
                selectedEstateIndex = -1;
                return;
            }

            selectedEstateIndex = estateIndexes[selectedRow]; //use estateindexes to let the program know which estate the selected index belongs to.
        }

        private Estate CreateEstateFromInputs() //method to create estates, used when applying changes of a modified estate and adding an estate.
        {
            try //some exception stuff wrapped around the block of code.
            {
                int id = int.Parse(txtID.Text); //all of this code is basically a blueprint of how the estates are created.
                string street = txtStreet.Text; 
                string zipCode = txtZipCode.Text;
                string city = txtCity.Text;
                Countries country = (Countries)cmbCountry.SelectedItem;

                Address address = new Address(street, zipCode, city, country);

                switch (txtEstateSelected.Text) //create an estate from information from the estate planner display.
                    //all text, numbers etc are taken from the input from the fields in the program and then displayed in the listbox.
                {
                    case "Villa":
                        int rooms = int.Parse(txtNumberOfRooms.Text);
                        double livingArea = double.Parse(txtLivingArea.Text); //some of these want an int or a double. 
                        double gardenArea = double.Parse(txtGardenArea.Text);
                        bool hasGarage = chkHasGarage.Checked;

                        return new Villa(id, address, rooms, livingArea, hasGarage, gardenArea);
                    case "Shop":
                        int numberOfEmployees = int.Parse(txtNumberOfEmployees.Text);
                        double businessArea = double.Parse(txtBusinessArea.Text);
                        int numberOfEntrances = int.Parse(txtNumberOfEntrances.Text);
                        bool hasStorage = chkHasStorage.Checked;

                        return new Shop(id, address, numberOfEmployees, businessArea, hasStorage, numberOfEntrances);
                    case "School":
                        int capacity = int.Parse(txtCapacity.Text);
                        int numberOfClassrooms = int.Parse(txtNumberOfClassrooms.Text);
                        int numberOfBuildings = int.Parse(txtNumberOfBuildings.Text);
                        bool hasCafeteria = chkHasCafeteria.Checked;

                        return new School(id, address, capacity, numberOfBuildings, hasCafeteria, numberOfClassrooms);
                }
                return null;
            }
            catch (FormatException) //without valid input exception the program would crash, now we have a warning instead. 
            //doesn't specify where the input is wrong, so that is a flaw. this makes sure that a field that wants numbers gets numbers. 
            //string fields allow numbers.
            {
                MessageBox.Show("Please enter valid input!",
                    "Invalid input.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return null;
            }
            catch (OverflowException) //if a number is too big or too small. would also crash the program without this exception.
            {
                MessageBox.Show("One of the input values are too large or too small.",
                    "Invalid input.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return null;
            }
        }

        private void DisplayEstate(Estate estate) //method to change the selected estate, changes the estate planner display and retrieves the variables of the
            //selected estate for the user to choose which to change.
        {
            txtID.Text = estate.ID.ToString();
            txtStreet.Text = estate.Address.Street;
            txtZipCode.Text = estate.Address.ZipCode;
            txtCity.Text = estate.Address.City;
            cmbCountry.SelectedItem = estate.Address.Countries;

            switch (estate) //im not a fan of switch-cases, they don't look very clean. but here we take the information from whatever estate is selected
                //and put the information into the estate-planners display fields :)
            {
                case Villa villa:
                    txtEstateSelected.Text = "Villa";
                    UpdateEstateFields("Villa");

                    txtNumberOfRooms.Text = villa.NumberOfRooms.ToString();
                    txtLivingArea.Text = villa.LivingArea.ToString();
                    txtGardenArea.Text = villa.GardenArea.ToString();
                    chkHasGarage.Checked = villa.HasGarage;
                    break;
                case Shop shop:
                    txtEstateSelected.Text = "Shop";
                    UpdateEstateFields("Shop");

                    txtNumberOfEmployees.Text = shop.NumberOfEmployees.ToString();
                    txtBusinessArea.Text = shop.BusinessArea.ToString();
                    txtNumberOfEntrances.Text = shop.NumberOfEntrances.ToString();
                    chkHasStorage.Checked = shop.HasStorage;
                    break;
                case School school:
                    txtEstateSelected.Text = "School";
                    UpdateEstateFields("School");

                    txtCapacity.Text = school.Capacity.ToString();
                    txtNumberOfClassrooms.Text = school.NumberOfClassrooms.ToString();
                    chkHasCafeteria.Checked = school.HasCafeteria;
                    txtNumberOfBuildings.Text = school.NumberOfBuildings.ToString();
                    break;
            }
        }

        private void UpdateEstateList() //updates in two ways, estate index works by putting each line from the same estate into a separate list "estateIndexes".
                                        //this is used for selection purposes. 
                                        //each line for an estate will have the same index in the estateIndexes list, which is used to find the corresponding estate in the manager.
        {
            lstEstates.Items.Clear(); //the rest is managing the display. it uses ToStringArray to display estates in the listbox.
                                      //lstEstates stores each separate line in the estate for display. 
            estateIndexes.Clear();

            string[] estates = estateManager.ToStringArray();

            for (int i = 0; i < estates.Length; i++)
            {
                foreach (string line in estates[i].Split('\n')) //split lines at '\n' and add each line to listbox. 
                {
                    lstEstates.Items.Add(line);
                    estateIndexes.Add(i);
                }
            }

            //problem i faced here was that i couldn't select any line of the estate in the listbox and automatically know which estate to remove. so i put each line
            //for the corresponding estate into a separate list, all with the same index, so each line for the first estate added would have index 0. and now 
            //pressing any line within that estate will have the same index, so the program knows which estate im trying to modify/remove. 
        }

        private void InitializeDataFile() //initialize the data .json file.
        {
            try //
            {
                System.Diagnostics.Debug.WriteLine("trying to create json file"); //try to create json file.
                if (!File.Exists(filePath)) //if the file doesnt exist
                {
                    File.WriteAllText(filePath, "[]"); //create a json file
                }
                else //else, if file exists
                {
                    System.Diagnostics.Debug.WriteLine("file already exists"); //let the debugger know 
                }

                System.Diagnostics.Debug.WriteLine($"File location: {filePath}"); //provide the debugger with filepath
            }
            catch (IOException ex) //input / output exception, program fails to create or write the json file.
            {
                MessageBox.Show($"File error: {ex.Message}");
            }
            catch (UnauthorizedAccessException ex) //no permission to access or modification 
            {
                MessageBox.Show($"Access denied: {ex.Message}");
            }
        }

        private void SaveEstates() //save estates from listbox to file
        {
            try //another try catch with a few exceptions to prevent crashes
            {
                List<Estate> estates = new List<Estate>(); //new list of estates, reason for this is because the other estates list is private. 
                //so we temporarily copy the existing estates and put them into the .json file so we can keep the other estates list private for access reasons.

                for (int i = 0; i < estateManager.Count; i++) //go through each estate in the estate list.
                {
                    estates.Add(estateManager.GetAt(i)); //add each estate to the new list. use GetAt from estatemanager
                }

                JsonSerializerOptions options = new JsonSerializerOptions //this is to make the json file readable. puts each "input" in its own line
                //without this everything was written in one line. didnt look very good.
                {
                    WriteIndented = true
                };
                string json = JsonSerializer.Serialize(estates, options); //include options when serializing the strings
                File.WriteAllText(filePath, json); //write the data!
            }
            catch (IOException ex) //error with saving file ^^
            {
                MessageBox.Show($"Error saving file: {ex.Message}");
            }
            catch (UnauthorizedAccessException ex) //no access to modifying or opening the json file
            {
                MessageBox.Show($"Access denied: {ex.Message}");
            }
            catch (JsonException ex) //serialization error.
            {
                MessageBox.Show($"Error serializing estates: {ex.Message}");
            }
        }

        private void LoadEstates() //method for loading saved estates upon starting the program
        {
            try //try catch exceptions
            {
                string json = File.ReadAllText(filePath); //read all the text 

            List<Estate> estates = JsonSerializer.Deserialize<List<Estate>>(json); //deserialize the contents of the json file

            if (estates != null) //if estates aren't null
            {
                foreach (Estate estate in estates) //go through all the estates
                {
                    estateManager.Add(estate); //and add them to the estatemanager
                }
            }

            UpdateEstateList(); //once added, update the listbox view with all the estates from the json file :)
            }
            catch (IOException ex) //error loading file
            {
                MessageBox.Show($"Error loading file: {ex.Message}");
            }
            catch (UnauthorizedAccessException ex) //no access to the file, or no access to modify the file
            {
                MessageBox.Show($"Access denied: {ex.Message}");
            }
            catch (JsonException ex) //deserialization error i think
            {
                MessageBox.Show($"Error de-serializing estates: {ex.Message}");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) //dialog box for saving when closing the program
        {
            DialogResult result = MessageBox.Show("Do you want to save and overwrite existing estate data?",
                "Save Estates",
                MessageBoxButtons.YesNoCancel, //this is the dialog, yes no cancel exists.
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes) //yes :)
            {
                SaveEstates(); //save and close.
            }
            else if (result == DialogResult.Cancel) //cancel :)
            {
                e.Cancel = true; //cancel from closing event
            }

            //if result is no the program will close without saving. no code needed.
        }
    }
}
