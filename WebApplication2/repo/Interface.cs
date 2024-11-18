namespace WebApplication2.repo
{
    public interface Iuser
    {
        user GetUserById(int id);
        void update(dto dto, int id);
        void add(dto dto);
        void delet( int id);

    }
}
