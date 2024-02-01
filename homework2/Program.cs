// See https://aka.ms/new-console-template for more information
                                                                                                                             using System; 
using System.Collections.Generic; 
using System.Linq; 
 
class Program
{
    static void Main()
    {
        // Example usage 
        List<int> numbers = new List<int> { 1, 5, 3, 8, 2, 7, 6 };

        // Find Middle Element(s) 
        List<int> middleElements = FindMiddleElements(numbers);
        Console.WriteLine("Middle Element(s): " + string.Join(", ", middleElements));

        // Find Largest Element 
        int largestElement = FindLargestElement(numbers);
        Console.WriteLine("Largest Element: " + largestElement);
    }

    // Function to find the middle element(s) of a list 
    static List<int> FindMiddleElements(List<int> list)
    {
        if (list.Count == 0)
        {
            // Empty list 
            return new List<int>();
        }

        int middleIndex = list.Count / 2;
        if (list.Count % 2 == 0)
        {
            // Even number of elements, return two middle elements 
            return new List<int> { list[middleIndex - 1], list[middleIndex] };
        }
        else
        {
            // Odd number of elements, return the middle element 
            return new List<int> { list[middleIndex] };
        }
    }

    // Function to find the largest element in a list 
    static int FindLargestElement(List<int> list)
    {
        if (list.Count == 0)
        {
            // Empty list 
            throw new ArgumentException("List is empty.");
        }

        return list.Max();
    }
}
