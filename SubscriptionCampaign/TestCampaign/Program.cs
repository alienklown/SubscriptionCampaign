Random random = new Random();
int daysUntilExpiration = 2;//random.Next(12);
int discountPercentage = 0;

if(daysUntilExpiration<6)
{
    //discountPercentage = 0;
    if(daysUntilExpiration <2)
    {
        discountPercentage=20;
    }
    
    else
    {
        discountPercentage = 10;//daysUntilExpiration;
    }
}
Console.WriteLine($"ATTN Admin: Days Until Subscription Expiration = {daysUntilExpiration}");
Console.WriteLine($"ATTN Admin: Discount Percentage Available to Advertise to this Client = {discountPercentage}%");
    


if(daysUntilExpiration>10)
{
    Console.WriteLine("Thank you for being a subscriber! I love you!");
}
else if(daysUntilExpiration>5)
{
    //discountPercentage = 10;
    Console.WriteLine($"Bizzy up renwal time u only got {daysUntilExpiration} days until expiration!");
}

else if(daysUntilExpiration>1)
    {
        //discountPercentage = 10;
        Console.WriteLine($"Your subscription is shrinking, only {daysUntilExpiration} days until expiration.");
        Console.WriteLine($"Renew now for a discount of {discountPercentage}%!, yo!");
    }

       else if(daysUntilExpiration>0)
        {
            //discountPercentage = 20;
            Console.WriteLine("Okay OKAY... You're breakin' my balls here!");
            Console.WriteLine($"Renew now for a {discountPercentage}% discount since you waited till the last day!");
        }
else
{
    Console.WriteLine("Your subscription has expired.");
    Console.WriteLine("Please renew now for immediate access and support!");
}
//Console.WriteLine($"ATTN Admin: Discount Percentage Available to Advertise to this Client = {discountPercentage}%");