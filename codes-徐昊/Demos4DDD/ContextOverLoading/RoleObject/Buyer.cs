namespace ContextOverLoading.RoleObject;

public class Buyer
{
  private User _user;
  private List<Order> _orders;

  public Buyer(User user)
  {
    _user = user;
  }

  public void PlaceOrder(Order order)
  {
  }
}