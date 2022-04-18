namespace sortalgorithm;

public class algorithm
{
    public Array BubbleSort(int[] a)
    {
        int axie;
        for (int j =a.Length; j >0; j--)
        {        
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i]<a[i-1])
                {
                    axie=a[i];
                    a[i]=a[i-1];
                    a[i-1]=axie;
                }
            }
        }
        return a;
    }
  
    //Uses recursion to break the collection
    //into progressively smaller collections.
    //Eventually, each collection will have just one element.
    // public List<int> Sort(List<int> unsorted)
    // {
    //     if (unsorted.Count <= 1)
    //     {
    //         return unsorted;
    //     }

    //     List<int> left = new List<int>();
    //     List<int> right = new List<int>();

    //     int median = unsorted.Count / 2;
    //     for (int i = 0; i < median; i++)  //Dividing the unsorted list
    //     {
    //         left.Add(unsorted[i]);
    //         foreach (var item in left)
    //         {
    //             System.Console.Write(" - {0}",item);
    //         }
    //         System.Console.WriteLine("//");
    //     }
    //     for (int i = median; i < unsorted.Count; i++)
    //     {
    //         right.Add(unsorted[i]);
    //         foreach (var item in right)
    //         {
    //             System.Console.Write(" - {0}",item);
    //         }
    //         System.Console.WriteLine("//");
    //     }

    //     left = Sort(left);
    //     right = Sort(right);
    //     return Merge(left, right);
    // }

    // //Method takes two sorted "sublists" (left and right) 
    // //of original list and merges them into a new colletion
    // public List<int> Merge(List<int> left, List<int> right)
    // {
    //     List<int> result = new List<int>(); //The new collection

    //     while (left.Any() || right.Any())
    //     {
    //         if (left.Any() && right.Any())
    //         {
    //             //Comparing the first element of each sublist 
    //             //to see which is smaller
    //             if (left.First() <= right.First())  
    //             {
    //                 result.Add(left.First());
    //                 left.Remove(left.First());      
    //             }
    //             else
    //             {
    //                 result.Add(right.First());
    //                 right.Remove(right.First());
    //             }
    //         }
    //         else if (left.Any())
    //         {
    //             result.Add(left.First());
    //             left.Remove(left.First());
    //         }
    //         else if (right.Any())
    //         {
    //             result.Add(right.First());
    //             right.Remove(right.First());
    //         }
    //     }
    //     return result;
    // }

    public List<int> MergeSort(List<int> a)
    {
        if (a.Count<=1)
        {
            return a;
        }

        int length=a.Count;
        List<int> firstList;
        List<int> secondList;      


        for (int i = 0; i < length/2; i++)
        {
            firstList.Add(a[i]);     
            
        }
            
           
        for (int i = 0; i < secondArray.Length; i++)
        {
            secondArray[i]=a[firstArray.Length+i];  
        }
            
        foreach (var item in firstArray)
        {
            System.Console.Write("- {0}",item);
        }    
            
        foreach (var item in secondArray)
        {
            System.Console.Write("- {0}",item);
        }    

        firstArray=MergeSort(firstArray);
        secondArray=MergeSort(secondArray);
        return Merge(firstArray , secondArray, a.Length);
    }

    public int[] Merge(int[] first, int[] second, int a)
    {
        int[] ornedana=new int[a];

        
        while(first.Any() || second.Any())
        {
            if (first.Any() && second.Any())
            {
                if (first.First() <= second.First())
                {
                    ornedana.Append(first.First());
                    ornedana.Append(second.First());
                } else{
                    ornedana.Append(second.First());
                    ornedana.Append(first.First());
                }
            }else if (first.Any())
            {
                ornedana.Append(first.First());                
            }
            else if (second.Any())
            {
                ornedana.Append(second.First());                

            }
        }
        return ornedana;
    }
}