namespace ContextOverLoading;

public class User
{
  // 社交上下文
  private List<Friendship> _friendships;
  public void Make(Friendship friendship)
  {
  }

  // 订阅上下文
  private List<Subscription> _subscriptions;
  public void Subscribe(Subscription subscription)
  {
  }

  // 订单上下文
  private List<Order> _orders;
  public void PlaceOrder(Order order)
  {
  }
}