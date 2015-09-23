using UnityEngine;
using System.Collections;

public class Loops : MonoBehaviour
{

    int cupsinthesink = 4;

     
      void Start()
      {
          while (cupsinthesink > 0)
          {
              Debug.Log("I've washed a cup!");
              cupsinthesink--;
          }
      }


 /* 

             void Start()
                  {
                      do
                      {
                          Debug.Log("I've washed a cup!");
                          cupsinthesink--;
                      } while (cupsinthesink > 0);

                  }





                  void Start()
                  {
                      for (int i=0; i<cupsinthesink; i++)
                      {
                          Debug.Log("I've washed a cup!");
                      }
                  }









                    void Start()
                    {
                        string[] strings = new string[3];

                        strings[0] = "First String";
                        strings[1] = "Second String";
                        strings[2] = "Third string";

                        foreach (string Str in strings)
                        {
                            print(Str);
                        }

                    }

      */


}
