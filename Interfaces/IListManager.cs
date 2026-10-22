///<summary>
///this is where some of the new stuff comes in. this class was made as a generic list interface. it is used to manage lists of objects of type T.
///this interface contains methods for adding, removing, getting, changing and converting the list to a string array. 
///this interface is also implemented by the ListManager class.
/// </summary>

namespace Nordic_Real_Estates___Version_2
{
    public interface IListManager<T>
    {
        bool Add(T item);
        bool RemoveAt(int index);

        T GetAt(int index);

        bool ChangeAt(int index, T item);

        string[] ToStringArray();
    }
}
