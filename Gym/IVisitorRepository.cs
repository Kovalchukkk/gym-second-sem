namespace Gym
{
    public interface IVisitorRepository : IRepository<Visitor>
    {
        void ShowDiscount(int indx);
        void ShowTheMostPopularTrainer();

    }
}
