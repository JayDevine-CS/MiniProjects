# Jay Devine - Sudoku Solver
# This small project allows for a sudoku board to be solved using Recursion and Backtracking
# to ensure if a wrong number is entered the algorithm will go back and fix the wrong number.


board = [
    [7, 8, 0, 4, 0, 0, 1, 2, 0],
    [6, 0, 0, 0, 7, 5, 0, 0, 9],
    [0, 0, 0, 6, 0, 1, 0, 7, 8],
    [0, 0, 7, 0, 4, 0, 2, 6, 0],
    [0, 0, 1, 0, 5, 0, 9, 3, 0],
    [9, 0, 4, 0, 6, 0, 0, 0, 5],
    [0, 7, 0, 3, 0, 0, 0, 1, 2],
    [1, 2, 0, 0, 0, 7, 4, 0, 0],
    [0, 4, 9, 2, 0, 6, 0, 0, 7]
]


# Print Board
def print_board(bo):
    # Print Row Lines when 'i' is divisible by 3 to create 3x3 grids
    for i in range(len(bo)):
        if i % 3 == 0 and i != 0:
            print("- - - - - - - - - - - - ")
            # Print Column Lines when 'j' is divisible by 3 to create 3x3 grids

        for j in range(len(bo[0])):
            if j % 3 == 0 and j != 0:
                print(" | ", end="")
            # Checking if end position has been reached. If so a new line will either be created or ignored
            if j == 8:
                print(bo[i][j])
            else:
                print(str(bo[i][j]) + " ", end="")


# Find empty square on Board and return position
def find_empty(bo):
    for i in range(len(bo)):
        for j in range(len(bo[0])):
            if bo[i][j] == 0:
                return (i, j)  # Row, Column (Position)

    return None


# Find whether the current square is Valid
def valid(bo, num, pos):
    # Check row
    for i in range(len(bo[0])):
        # Check each element in row and see if its equal to the number added
        if bo[pos[0]][i] == num and pos[1] != i:
            return False

    # Check column
    for i in range(len(bo)):
        # Check each element in Column does not match the number added
        if bo[i][pos[1]] == num and pos[0] != i:
            return False

    # Check box
    box_x = pos[1] // 3
    box_y = pos[0] // 3

    # Loop through the box and check if any other elements equal the number added
    for i in range(box_y * 3, box_y * 3 + 3):
        for j in range(box_x * 3, box_x * 3 + 3):
            if bo[i][j] == num and (i, j) != pos:
                return False
    # If all checks are passed then return True as it must be Valid
    return True


# Solve the board and fill in values
def solve(bo):
    # Check whether 'find_empty' found an empty square or not
    find = find_empty(bo)
    if not find:
        return True
    else:
        row, col = find
    # Loop through values 1 to 10 and see if they're valid
    for i in range(1, 10):
        # If they're Valid they will then be inserted into the board
        if valid(bo, i, (row, col)):
            bo[row][col] = i
            # Recursively try to finish solution until complete or returns false
            if solve(bo):
                return True
            # If cannot be solved reset value and repeat process recursively
            bo[row][col] = 0

    return False

print("Original Board :")
print_board(board)
solve(board)
print("\n"
      "Complete Board :")
print_board(board)
