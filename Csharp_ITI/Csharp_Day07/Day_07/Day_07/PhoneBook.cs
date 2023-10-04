namespace Day_07;

 struct PhoneBook
 {
     private string[] Names;
     private long[] Numbers;
     private int size;

     public int Size  {get { return size; } }

     public PhoneBook(int _Size)
     {
         size = _Size;
         Names = new string[size];
         Numbers = new long [size];
         
     }

     public void SetEntry(int index, string name, long number)
     {
         if (index >= 0 && index < size)
         {
             Names[index] = name;
             Numbers[index] = number;
         }
     }

     public long GetNumber(string name)
     {
         for (int i = 0; i < Names?.Length; i++)
         {
             if (Names[i] == name)
                 return Numbers[i];
         }
         return -1;
     }
    
     
     // indexer ===> when you have to attributes related to each other We should use it 
     public long this[string Name]
     {
         get
         {
             for (int i = 0; i < Names?.Length; i++)
             {
                 if (Names[i] == Name)
                     return Numbers[i];
             }
             return -1;
         }
         set
         {
             for (int i = 0; i < Names?.Length; i++)
             {
                 if (Names[i] == Name)
                     Numbers[i] = value;
             }
         }
     }

     public string this[int index]
     {
         get
         {
             if (index >= 0 && index < size)
                 return $"{Names[index]} ::: {Numbers[index]}";

             return "NA";
         }
     }

     public long this[int index, string Name]
     {
         set
         {
             if (index >= 0 && index < size)
             {
                 Names[index] = Name;
                 Numbers[index] = value;
             }
             
         }
     }

     
     
 }