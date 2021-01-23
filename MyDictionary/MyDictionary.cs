using System;

namespace MyDictionary
{
    class MyDictionary<T1, T2, T3>
    {
        T1[] ID;
        T2[] EnglishWord;
        T3[] TurkishWord;

        
        public MyDictionary()
        {
            ID = new T1[0];
            EnglishWord = new T2[0];
            TurkishWord = new T3[0];
        }

        public void Add(T1 Id, T2 englishWord, T3 turkishWord)
        {
            T1[] tempArray = ID;
            T2[] tempArray2 = EnglishWord;
            T3[] tempArray3 = TurkishWord;

            ID = new T1[ID.Length + 1];
            EnglishWord = new T2[EnglishWord.Length + 1];
            TurkishWord = new T3[TurkishWord.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                ID[i] = tempArray[i];
                EnglishWord[i] = tempArray2[i];
                TurkishWord[i] = tempArray3[i];
            }

            ID[ID.Length - 1] = Id;
            EnglishWord[EnglishWord.Length - 1] = englishWord;
            TurkishWord[TurkishWord.Length - 1] = turkishWord;
        }

        public T1[] Id
        {
            get { return ID; }
        }
        public T2[] englishWord
        {
            get { return EnglishWord; }
        }
        public T3[] turkishWord
        {
            get { return TurkishWord; }
        }

        public string Length { get; internal set; }

    }
    
}
