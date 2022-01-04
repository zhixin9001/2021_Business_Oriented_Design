namespace ContextOverLoading.RoleObject;

public class Reader
{
  private User _user;
  private List<Subscription> _subscriptions;
  
  public Reader(User user)
  {
    _user = user;
  }
  
  public void Subscribe(Subscription subscription)
  {
  }
}