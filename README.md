### Data Structure

Data Structure is a way of collecting and organising data in such a way that we can perform operations on these data in an effective way.

### Algorithm

An algorithm is a set of instructions for solving a problem or accomplishing a task.

### Algorithm Efficiency

The complexity of an algorithm is a function describing the efficiency of the algorithm in terms of the amount of data the algorithm must process.

There are two main complexity measures of the efficiency of an algorithm:

- Time complexity
- Space complexity

For both time and space, we are interested in the asymptotic complexity of the algorithm.

### Time complexity 

Time complexity is a function describing the amount of time an algorithm takes in terms of the amount of input to the algorithm.

### Space complexity 

Space complexityis a function describing the amount of memory (space) an algorithm takes in terms of the amount of input to the algorithm.

### Asymptotic Notation

These are the mathematical notations that are used for the asymptotic analysis of the algorithms. The most common notation used is "big O" notation.

### Big O Notation

It measures how quickly the run-time grows relative to the input, as the input increases of an algorithm. Another way to say, it is used for calculating the worst-case complexity of an algorithm.

![Big O Complexity Chart](./assets/big-o-chart.png)

Source: [Big O Cheat Sheet](http://bigocheatsheet.com/)

Below is the list of some of the most used Big O notations and their performance comparisons against different sizes of the input data.

| Big O Notation | Computations for 10 elements | Computations for 100 elements | Computations for 1000 elements  |
| -------------- | ---------------------------- | ----------------------------- | ------------------------------- |
| **O(1)**       | 1                            | 1                             | 1                               |
| **O(log N)**   | 3                            | 6                             | 9                               |
| **O(N)**       | 10                           | 100                           | 1000                            |
| **O(N log N)** | 30                           | 600                           | 9000                            |
| **O(N^2)**     | 100                          | 10000                         | 1000000                         |
| **O(2^N)**     | 1024                         | 1.26e+29                      | 1.07e+301                       |
| **O(N!)**      | 3628800                      | 9.3e+157                      | 4.02e+2567                      |

Source: [javascript-algorithms](https://github.com/trekhleb/javascript-algorithms#big-o-notation)

##### Resource Links

- [Ace Your Coding Interview by Understanding Big O Notation — and Write Faster Code](https://medium.com/@bretcameron/ace-your-coding-interview-by-understanding-big-o-notation-and-write-faster-code-6b60bd498040)
- [Big O Notation - Full Course](https://www.youtube.com/watch?v=Mo4vesaut8g)