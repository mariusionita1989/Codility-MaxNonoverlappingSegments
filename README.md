# Codility-MaxNonoverlappingSegments
Located on a line are N segments, numbered from 0 to N − 1, whose positions are given in arrays A and B.</br>
For each I (0 ≤ I < N) the position of segment I is from A[I] to B[I] (inclusive).</br>
The segments are sorted by their ends, which means that B[K] ≤ B[K + 1] for K such that 0 ≤ K < N − 1.

Two segments I and J, such that I ≠ J, are overlapping if they share at least one common point.</br> 
In other words, A[I] ≤ A[J] ≤ B[I] or A[J] ≤ A[I] ≤ B[J].

We say that the set of segments is non-overlapping if it contains no two overlapping segments.</br> 
The goal is to find the size of a non-overlapping set containing the maximal number of segments.

For example, consider arrays A, B such that:</br>
A[0] = 1    B[0] = 5</br>
A[1] = 3    B[1] = 6</br>
A[2] = 7    B[2] = 8</br>
A[3] = 9    B[3] = 9</br>
A[4] = 9    B[4] = 10
             
The size of a non-overlapping set containing a maximal number of segments is 3.</br> 
For example, possible sets are {0, 2, 3}, {0, 2, 4}, {1, 2, 3} or {1, 2, 4}.  
There is no non-overlapping set with four segments.

Write a function:</br>
class Solution { public int solution(int[] A, int[] B); }</br>
that, given two arrays A and B consisting of N integers, returns the size of a non-overlapping set containing a maximal number of segments.</br>
For example, given arrays A, B shown above, the function should return 3, as explained above.

Write an efficient algorithm for the following assumptions:</br>
N is an integer within the range [0..30,000];</br>
each element of arrays A and B is an integer within the range [0..1,000,000,000];</br>
A[I] ≤ B[I], for each I (0 ≤ I < N);</br>
B[K] ≤ B[K + 1], for each K (0 ≤ K < N − 1).
