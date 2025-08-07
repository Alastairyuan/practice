using static System.Convert;
using static SplashKitSDK.SplashKit;

String name, things;
String userInput;
double dollars, time;
double predollars, weeklymoney;
double weeklyneedsavemoney, cuweek;
Write("What is you name?:");
name = ReadLine();
WriteLine();
WriteLine($"Hi {name}");
WriteLine();

Write("What are you saving for?");
things = ReadLine();

Write("How much do you need to save? ");
userInput = ReadLine();
dollars = ToDouble(userInput);

Write("How long before the purchase? ");
userInput = ReadLine();
time = ToDouble(userInput);

Write("How much do you have already? ");
userInput = ReadLine();
predollars = ToDouble(userInput);

Write("How much can you save each week?");
userInput = ReadLine();
weeklymoney = ToDouble(userInput);

weeklyneedsavemoney = (dollars - predollars) / time;
cuweek = (dollars - predollars) / weeklymoney;

WriteLine($"For the Holiday, you need to save {weeklyneedsavemoney} dollars a week");
WriteLine($"Based on current savings you will need {cuweek} weeks to save {dollars}");