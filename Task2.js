function validSolution(board){
    for(let row = 0; row < 9; row++){
      const rowSet = new Set(board[row]);
      if(rowSet.size !== 9 || rowSet.has(0)) return false;
    }
    
    for(let col = 0; col < 9; col++){
      const colSet = new Set();
      for(let row = 0; row < 9; row++){
        colSet.add(board[row][col]);
      }
      if(colSet.size !== 9 || colSet.has(0)) return false;
    }
    
    for(let row = 0; row < 9; row += 3){
      for(let col = 0; col < 9; col += 3){
        const blockSet = new Set();
        for(let i = row; i < row + 3; i++){
          for(let j = col; j < col + 3; j++){
            blockSet.add(board[i][j]);
          }
        }
        if(blockSet.size !== 9 || blockSet.has(0)) return false;
      }
    }
    
    return true;
  }