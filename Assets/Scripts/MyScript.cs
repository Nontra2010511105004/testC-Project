using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    
    void Start()
    {
       //1.print number1-100 by using for loop
       //2.print even number 1*100 using for loop(2 4 6 8 10...100)
       //3.create a function that calculater area of a circle and print out the result.
       for(int i=0; i<=100; i++)
       {
           print(i);
       }
       for(int i=2; i<=100; i++)
       {
           if(i % 2 == 0)
           {
             print( i);
            }
       }
       int z=1;
       while(z<=100)
       {
             print(z);
                z += 2;
        }
        
       float x=1.0f;
       float r= circle(x);
    }
    
    float circle(float r)
    {
            r=2.0f;
           float result = 3.14f*(r*r);
           print( result );
           return result;
    
    }
}
// given width is 10 point.height is 5 point.calculate area of ratangle and reint out