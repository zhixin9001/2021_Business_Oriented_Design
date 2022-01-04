namespace ContextOverLoading;

using RoleObject;

public interface IUserRepository
{
  User FindById(long id);
  Buyer AsBuyer(User user);
  Reader AsReader(User user);
}