using Codility_MaxNonoverlappingSegments;

namespace Codility_MaxNonoverlappingSegmentsTests
{
    public class SolutionTests
    {
        [Fact]
        public void Solution_WithEmptyArrays_ShouldReturnZero()
        {
            // Arrange
            int[] A = new int[] { };
            int[] B = new int[] { };

            // Act
            Solution solution = new Solution();
            int result = solution.solution(A, B);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Solution_WithNonOverlappingSegments_ShouldReturnMaximalSize()
        {
            // Arrange
            int[] A = new int[] { 1, 3, 7, 9, 9 };
            int[] B = new int[] { 5, 6, 8, 9, 10 };

            // Act
            Solution solution = new Solution();
            int result = solution.solution(A, B);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Solution_WithOverlappingSegments_ShouldReturnMaximalSize()
        {
            // Arrange
            int[] A = new int[] { 1, 3, 7, 9, 9, 12 };
            int[] B = new int[] { 5, 6, 8, 9, 10, 15 };

            // Act
            Solution solution = new Solution();
            int result = solution.solution(A, B);

            // Assert
            Assert.Equal(4, result);
        }
    }
}