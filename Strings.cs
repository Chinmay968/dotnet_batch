using System;
using System.Text;

    namespace StringOperation{
        class Operations{
            static void Main (String[] args){
                StringOperation.concatenation.concat();
                StringOperation.Builder.build();

            }

        }

        class concatenation{
            public static void concat(){

                 string s1 = "Hello ";
                 string s2 = "Myself Chinmay Daund ";
                 string result = s1 + s2;
                 Console.WriteLine(result);

            }
        }
        class Builder {
            public static void build(){
                
                StringBuilder addWord = new StringBuilder ("Hello ");
                addWord.Append ("Myself Chinmay Daund");
                Console.WriteLine(addWord);

            }
        }    
        
    }