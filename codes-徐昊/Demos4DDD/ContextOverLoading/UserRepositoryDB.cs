namespace ContextOverLoading;

using RoleObject;

public class UserRepositoryDB : IUserRepository
{
  // public User FindById(long id)
  // {
  //   return db.ExecuteQuery(...);
  // }
  //
  // public Buyer AsBuyer(User user)
  // {
  //   return new Buyer(user, db.ExecuteQuery(...));
  // }
  //
  // public Reader AsReader(User user)
  // {
  //   return new Reader(user, db.ExecuteQuery(...));
  // }
  public User FindById(long id)
  {
    throw new NotImplementedException();
  }

  public Buyer AsBuyer(User user)
  {
    throw new NotImplementedException();
  }

  public Reader AsReader(User user)
  {
    throw new NotImplementedException();
  }
}