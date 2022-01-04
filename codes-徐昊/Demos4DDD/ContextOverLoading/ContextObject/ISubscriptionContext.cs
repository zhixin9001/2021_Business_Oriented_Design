namespace ContextOverLoading.ContextObject;

public interface ISubscriptionContext
{
  interface IReader
  {
    void Subscribe(Subscription subscription);
    void Transfer(Subscription subscription, User user);
    Subscription GetSubscription(int id);
  }

  IReader AsReader(User user);
}