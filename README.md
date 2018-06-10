# SortingAlgorithmsInCSharp
A basic implementation of sortings algorithms in C# and comparison of their performance.

## Performance

### Array size 1.000 ,Random numbers from 0 to 100

Output
```
Size of the shuffled array :1000
Bubble Sort Took(miliseconds):6
Selection Sort Took(miliseconds):2
Insertion Sort Took(miliseconds):2
Shell Sort Took(miliseconds):0
Merge Sort Took(miliseconds):0
Quick Sort Took(miliseconds):0
Counting Sort Took(miliseconds):0
Radix Sort Took(miliseconds):0
```

### Array size 10.000 ,Random numbers from 0 to 100

Output
```
Size of the shuffled array :10000
Bubble Sort Took(miliseconds):678
Selection Sort Took(miliseconds):231
Insertion Sort Took(miliseconds):154
Shell Sort Took(miliseconds):2
Merge Sort Took(miliseconds):5
Quick Sort Took(miliseconds):3
Counting Sort Took(miliseconds):0
Radix Sort Took(miliseconds):3
```


### Array size 100.000 ,Random numbers from 0 to 100

Output
```
Size of the shuffled array :100000
Shell Sort Took(miliseconds):28
Merge Sort Took(miliseconds):34
Counting Sort Took(miliseconds):2
Radix Sort Took(miliseconds):24
```

### Array size 1.000.000 ,Random numbers from 0 to 100

Output
```
Size of the shuffled array :1000000
Shell Sort Took(miliseconds):368
Merge Sort Took(miliseconds):365
Counting Sort Took(miliseconds):29
Radix Sort Took(miliseconds):237
```
### Array size 10.000.000 ,Random numbers from 0 to 100

Output
```
Size of the shuffled array :10000000
Shell Sort Took(miliseconds):4765
Merge Sort Took(miliseconds):4476
Counting Sort Took(miliseconds):283
Radix Sort Took(miliseconds):2510
```

## To summarize
Radix sort is most powerful algorithm in my opinion because it eliminates Counting Sort's variable scope problem and its fast, inplace and stable algorithm.
