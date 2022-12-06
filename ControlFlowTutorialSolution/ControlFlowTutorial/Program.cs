
var state = "OH";
var city = "Cincinnati";
string salesperson = String.Empty;


salesperson = state switch
{
    "OH" => "Karl",
    "KY" => "Sam",
    "IN" => "Ian",
    _ => "Greg"
};





int i = 100;
int sum = 0;
while (i > 0)
{
    sum += i;
    i--; 




}
Console.WriteLine($"Sum of number 1 to 100 is {sum}"); 









//switch(state)
//{
//    case "OH":
//        Console.WriteLine("Ohio");
//        break;
//    case "KY":
//        Console.WriteLine("Kentucky");
//        break;
//    case "IN":
//        Console.WriteLine("Indiana");
//        break;
//    default:
//        Console.WriteLine("It is not a tristate state");
//        break ;



//}


if(state == "OH") {
         Console.WriteLine("State is Ohio");
    if (city == "Cincinnati")
    {
        Console.WriteLine("City is Cincinnati");
    }
    else if (city == "Columbus")
    {
        Console.WriteLine("City is Columbus");
    } else
    {
        Console.WriteLine("City is Cleveland");

    }
} else{
    if (state == "KY") 
        { Console.WriteLine("State is Kentucky");
    } else 
        { Console.WriteLine("State is not Ohio or Kentucky"); }
}




//======================================

var boolean = true;

if (boolean)
{
    Console.WriteLine("Boolean is True!");
} else
{
    Console.WriteLine("Boolean is False!");
}



do { sum += i;
    i--;

} while (i > 0); 


















