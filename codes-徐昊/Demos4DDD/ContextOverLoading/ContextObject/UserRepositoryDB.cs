namespace ContextOverLoading.ContextObject;

public class UserRepositoryDB: IUserRepository
{
  //通过依赖注入获取不同的上下文对象
  private ISubscriptionContext subscriptionContext;
  private ISocialContext socialContext;
  private IOrderContext orderContext;
  
  public User FindUserById(long id)
  {
    throw new NotImplementedException();
  }

  public ISubscriptionContext InSubscriptionContext()
  {
    throw new NotImplementedException();
  }

  public ISocialContext InSocialContext()
  {
    throw new NotImplementedException();
  }

  public IOrderContext InOrderContext()
  {
    throw new NotImplementedException();
  }
}