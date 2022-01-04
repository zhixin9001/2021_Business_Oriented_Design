// See https://aka.ms/new-console-template for more information

// using ContextOverLoading;
//
// var repo = new UserRepositoryDB();
// var user = repo.FindById(1);
// var buyer = repo.AsBuyer(user);
// var reader = repo.AsReader(user);

using ContextOverLoading.ContextObject;

var repo = new UserRepositoryDB();
var user = repo.FindUserById(1);
// var buyer = repo.InOrderContext().AsBuyer(user);
// var reader = repo.InSubscriptionContext().AsReader(user);
// var contact = repo.InSocialContext().AsContact(user);


// 上下文依赖：专栏的赠送
var friend = repo.FindUserById(2);
var reader = repo.InSubscriptionContext().AsReader(user);
var subscription = reader.GetSubscription(1);
reader.Transfer(subscription, friend);