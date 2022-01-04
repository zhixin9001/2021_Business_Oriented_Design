namespace AssociationObject;

public class User
{
  // private UserRepository _userRepository;
  private IMySubscriptions _mySubscriptions;
  private List<Subscription> subscriptions;

  // 获取用户订阅的所有专栏
  public List<Subscription> getSubscriptions()
  {
    _mySubscriptions.Skip(0).Take(10);
    return null;
  }

  // 计算所订阅的专栏的总价
  public double getTotalSubscriptionFee()
  {
    return 0;
  }
}