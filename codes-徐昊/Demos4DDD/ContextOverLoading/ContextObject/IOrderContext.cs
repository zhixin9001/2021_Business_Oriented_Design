namespace ContextOverLoading.ContextObject;

public interface IOrderContext
{
  interface IBuyer
  {
    void PlaceOrder(Order order);
  }

  IBuyer AsBuyer(User user);
}