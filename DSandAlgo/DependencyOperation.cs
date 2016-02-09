/* 
Operations:
A, B, C, D, E, F, G
    
Dependencies:
B depends on A
C depends on A
A depends on G
A depends on D
E depends on D
E depends on F
    
Sample Output:
G, D, F, A, E, B, C
*/

/*    
    0,1
  0 A,B  => G,A
  1 A,C  => D,A
  3 G,A  => F,E
  4 D,A  => A,B
  5 D,E  => A,C 
  6 F,E
  
  //algo
  Represent the depenecy in 2XN array
  Fill it up with dependency given
  sort the array based on col. 0
  print col. 0 wihtout dup.
  then print col. 1 with out dup.
  
  class DependencyOperations
  {
  
      public static void Main(string [] args)
      {
          int LengthOfOperatoin=7;
          int [][] d= new int [][] 
          {
              {0,1},
              {0,2},
              {6,0},
              {3,0},
              {3,4},
              {5,4}                      
          }
          
          for(int r=0;r<d[0].Length;r++)
          {
          
             
             //Check if it is presnt on col=1
             //if present bring it's parent on top
             for(int r1=r;r1<d[0].Length;r1++)
             {
                 if(d[r][0]==d[r1][1])
                  {
                      //Swap with r
                     t=d[r][0];
                     t1=d[r1][0];
                     d[r][0]=d[r1][0];
                     d[r][1]=d[r1][1];
                     d[r1][0]=t;
                     d[r1][1]=t1;
                  
                  }
             
             }
             
             HashSet printed = new HashSet();
             int [] result = new int [LengthOfOperatoin];
             for(int r=0;r<result.Length;r++)
             {
                 for(int i=0;i<d[0].Length;i++)
                 {
                     if(h.Contains(d[0][i])==false)
                     {
                         result[r]=d[0][i];
                      }
                 
                 
                 }
                 
                 for(int i=0;i<d[1].Length;i++)
                 {
                     if(h.Contains(d[1][i])==false)
                     {
                         result[r]=d[1][i];
                      }
                 
                 
                 }
                 
             }
             
             for(int i=0;i<result.Length;i++)
             {
                 Console.Write(result[i]);
             
             }
          
          
          
          }
          
          
          
          
          
      
      }
      
  
  
  
  
  }
  

*/