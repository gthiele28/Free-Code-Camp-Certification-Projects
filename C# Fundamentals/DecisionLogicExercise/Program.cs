Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here
if (daysUntilExpiration > 10){
    
}
else if (daysUntilExpiration > 5) 
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
} 
else if (daysUntilExpiration > 1) 
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save 10%!");
} 
else if (daysUntilExpiration == 1) 
{
    Console.WriteLine("Your subscription expires within a day!\nRenew now and save 20%!");
}
else
{
    Console.WriteLine("Your subscription has expired.");
}