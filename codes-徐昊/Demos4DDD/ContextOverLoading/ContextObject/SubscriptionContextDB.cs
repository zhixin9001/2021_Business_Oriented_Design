namespace ContextOverLoading.ContextObject;

public class SubscriptionContextDB : ISubscriptionContext
{
  private ISocialContext _socialContext;
  public ISubscriptionContext.IReader AsReader(User user)
  {
    throw new NotImplementedException();
  }
}

public class Reader : ISubscriptionContext.IReader
{
  private ISocialContext _socialContext;
  private User _user;
  private List<Subscription> _subscriptions;
  public void Subscribe(Subscription subscription)
  {
    throw new NotImplementedException();
  }

  public void Transfer(Subscription subscription, User user)
  {
    _socialContext.AsContact(_user).IsFriend(user);
    throw new NotImplementedException();
  }

  public Subscription GetSubscription(int id)
  {
    throw new NotImplementedException();
  }
}