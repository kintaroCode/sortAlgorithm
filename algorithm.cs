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

    public int MergeSort(int[] a)
    {
        int length=a.Length;
        int[] firstArray;
        int[] secondArray;
        if(!(a.Length%2==0))
        {
            firstArray=new int[(length+1)/2];
            secondArray=new int[(length-1)/2];
        }else{       
            firstArray=new int[length/2];
            secondArray=new int[length/2];
        }


        for (int i = 0; i < firstArray.Length; i++)
        {
            firstArray[i]=a[i];          
            System.Console.Write(" - {0}",firstArray[i]);      

        }
            System.Console.WriteLine(firstArray.Length);    
        for (int i = 0; i < secondArray.Length; i++)
        {
            secondArray[i]=a[firstArray.Length+i];   
            System.Console.WriteLine(" - {0}", secondArray[i]);

        }
            System.Console.WriteLine(secondArray.Length);    

        return firstArray.Length;


    }
}