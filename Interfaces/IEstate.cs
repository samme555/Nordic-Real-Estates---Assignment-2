///<summary>
///the core of all estates i suppose? was implemented for A1 and ended up being half-wrong I suppose. either way I added the address property to this class.
///from my understanding an interface is some kind of "contract" for the classes that implement it. so this interface means that all the inheriting
///classes (which is Estate) must have an ID and an Address property. 
///either way i think the program would work if this class didn't exist but it's here because i thought i had to keep it for the D grade for A2.
///since Estate is the only class directly inheriting from this class it means that residential, commercial etc don't need to implement ID and address since
///they already do from the Estate class, whihc they are instead inheriting from.
/// </summary>

namespace Nordic_Real_Estates___Version_2
{
    public interface IEstate
    {
        int ID { get; set; }
        Address Address { get; set; }
    }
}
