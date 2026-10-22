///<summary>
///holds all relevant code for the estatemanager. inherits from the generic ListManager<T> class, and is also used to manage a list of estates. 
///however, that management is done through the estatemanager.
/// </summary>

namespace Nordic_Real_Estates___Version_2
{
    public class ListManager<T> : IListManager<T> //inherit from interface
    {
        private List<T> items = new List<T>();
        public int Count => items.Count; //return the count of items in the list.

        public bool Add(T item)
        {
            if (item is null) //if item doesnt exist, return false
                return false;

            items.Add(item); //if item exists, return true
            return true;
        }

        public bool RemoveAt(int index)
        {
            if (index < 0 || index >= items.Count) //if index is out of range, return false
                return false;

            items.RemoveAt(index); //if item isn't out of range, return true.
            return true;
        }

        public T GetAt(int index)
        {
            if (index < 0 || index >= items.Count)
                throw new ArgumentOutOfRangeException(nameof(index)); //throw exception because we want to inform the caller that this method must return an object of type T.

            return items[index];
        }

        public bool ChangeAt(int index, T item)
        {
            if (index < 0 || index >= items.Count || item is null) //if index out of range, or item null. return false.
                return false;

            items[index] = item;
            return true;
        }

        public string[] ToStringArray()
        {
            string[] result = new string[items.Count]; //create string array with same length as our items list.

            for (int i = 0; i < items.Count; i++) //go through all elements in array
            {
                result[i] = items[i].ToString(); //convert the results of the array to string results.
            }

            return result;
        }
    }
}
