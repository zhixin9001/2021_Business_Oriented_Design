namespace ContextOverLoading.ContextObject;

public interface ISocialContext
{
  interface IContact
  {
    void Make(Friendship friendship);
    bool IsFriend(User user);
  }

  IContact AsContact(User user);
}