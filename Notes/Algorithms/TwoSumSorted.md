* Since this array is sorted, we can do this bad boy in O(n) time. Lets start at the beginning of the array and the end of the array. We should check if the first element + the second element is equal to the target?
    * if it is -> return [i,j];
    * if array[j] > target -> j--;
    * if array[i] < target -> i++;
* finally, return [];