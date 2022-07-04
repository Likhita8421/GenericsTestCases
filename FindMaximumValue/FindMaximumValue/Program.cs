using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{

    public static void Main(string[] args)
    {

        FindMaximumValue.findMaximumValue<int> findMaximumValue = new FindMaximumValue.findMaximumValue<int>(10, 20, 30);
        findMaximumValue.findMax();
        FindMaximumValue.findMaximumValue<float> findMaxfloat = new FindMaximumValue.findMaximumValue<float>(10.5F, 20.5F, 30.5F);
        findMaxfloat.findMax();
        FindMaximumValue.findMaximumValue<string> findMaxstring = new FindMaximumValue.findMaximumValue<string>("Apple", "Banana", "Orange");
        findMaxstring.findMax();
        //new findMaximumValue<float>(10.5F, 20.5F, 30.5F).findMax();
        // new findMaximumValue<string>("Apple", "Banana", "Orange").findMax();
    }
}