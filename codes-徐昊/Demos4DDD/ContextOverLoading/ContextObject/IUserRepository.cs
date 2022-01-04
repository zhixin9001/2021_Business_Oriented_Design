namespace ContextOverLoading.ContextObject;

public interface IUserRepository
{
  User FindUserById(long id);
    
  ISubscriptionContext InSubscriptionContext();
  ISocialContext InSocialContext();
  IOrderContext InOrderContext();
}