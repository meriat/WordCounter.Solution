using System;
using System.Collections.Generic;
using System.Linq;
using WordCounter.Models;

namespace WordCounter.Models
{
    public class WordChecker
    {
        private string _input;
        private List <string> _inputList;
        //add constructor
        public WordChecker(string firstInput,string firstInputList)
        {
            _input = firstInput.ToLower();
            List<string> result = firstInputList.Split(' ').ToList();
            _inputList = result;

        }
        public string GetInput()
        {
            return _input;
        }
        public List<string> GetList()
        {
            return _inputList;
        }

        public bool IsWordEmpty()
        {
            //check if empty
             if (!_inputList.Any() || _input == "")
            {
               return true;
            }
            else
            {
                return false;
            }
        }
        public int RepeatCounter()
        {
            //compare input to the list elements and output the counter
            int counter = 0;
            if(IsWordEmpty())
            {
                return -1;
            }
            for(int i = 0; i < _inputList.Count; i ++)
            {
                 if(_input == (_inputList[i].ToLower()))
                    {
                        counter++;
                    }
            }

            return counter;
        }
    }
}
