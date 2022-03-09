namespace Gym
{
    public interface IRepository<T>
    {
        void Add(T item);
        void Del(int indx);
        void Show();
    }
}
