        public void RemoveAt(int index)
        {
            if(index < 0 || index >= Count) {throw new IndexOutOfRangeException();} //throw exception if index was not found

            //loop through from current index and shift the remaining values to cover the index being removed
            for (int i = index; i < data.Length-1; i++){
                data[i] = data[i+1]; 
            } 
            //make temporary array for downsizing
            T[] newdata = new T[data.Length-1];
            //copy array
            for (int j = 0; j < newdata.Length; j++) {
                newdata[j] = data[j]; 
            }
            //replace with resized array
            data = newdata;
            //decerement Count
            Count--;