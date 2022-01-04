namespace AssociationObject;

using System.Collections;
using System.Linq.Expressions;

public class MySubscriptionsDB : IMySubscriptions
{
  public IEnumerator<Subscription> GetEnumerator()
  {
    throw new NotImplementedException();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return GetEnumerator();
  }

  public Type ElementType { get; }
  public Expression Expression { get; }
  public IQueryProvider Provider { get; }
}