class Bootcamp {
	

 private int[,] internalCamp;
 private int x, y;

  Bootcamp( int x = 1, int y = 1) {
    
    if ( x <= 0 ) {
      x = 1;
    }

    if ( y <= 0 ) {
      y = 1;
    }

    x = (x <= 0 ) ? 1 : x;
    y = (y <= 0 ) ? 1 : y;

    this.x = x;
    this.y = y;

    this.buildCamp(0, 0, x, y);
  }


  private void buildCamp( int x, int y, int width, int height){
    
 	this.internalCamp = new int[width,height];

  	for(int row = x; row < width; row++){

  		for(int column = y; column < height; column++){
  			this.internalCamp[row,column] = 0;
  		}
  	}

  }


  public void setX( int width) {
    
    if( width < 0 ){
    	width = 1;
    }

	this.buildCamp(0, 0, width, this.y);

	this.x = width;
  }

  public int getX() {

    return this.x;
  
  }



  public void setY(int height) {

    if( height < 0 ){
    	height = 1;
    }

	this.buildCamp(0, 0, this.x, height);

	this.y = height;
  }

  public int getY(){

    return this.y;
  }


  public int[,] getCamp(){

    this._solve();
    return this.internalCamp;
  }

  string display(int x, int y){

    if (this.internalCamp[x,y] == 0) {
      return " ";
    }
     else if (this.internalCamp[x,y] == -1) {
      return "*";
    }

    return this.internalCamp[x,y].ToString();
  }

  public void changeBomb(int x, int y) {

    if (this._isBomb(x, y)) {
      this.clear(x, y);
    } else {
      this.setBomb(x, y);
    }

 }

  void setBomb(int x, int y){

    this.internalCamp[x,y] = -1;
  }


  void clear(int x, int y){

    this.internalCamp[x,y] = 0;
  }

  private bool _existsInCamp(int x, int y) {
      
    return this.internalCamp[x,y] != null;
    
  }

  private void _increment(int x, int y) {

    if (this._existsInCamp(x, y) && this.internalCamp[x,y] > -1) {
      this.internalCamp[x,y]++;
    }

  }

  private bool _isBomb(int x, int y) {
    return this.internalCamp[x,y] == -1;
  }

  private void _clear() {

    for (int r = 0; r < this.x; r++) {
      for (int c = 0; c < this.y; c++) {
        if (!this._isBomb(r, c)) {
          this.internalCamp[r,c] = 0;
        }
      }
    }
  }


  private void _solve(){

    this._clear();
    
    for (int r = 0; r < this.x; r++) {
      for (int c = 0; c < this.y; c++) {
        if (this._isBomb(r, c)) {
          this._increment(r - 1, c - 1);
          this._increment(r - 1, c);
          this._increment(r - 1, c + 1);

          this._increment(r, c - 1);
          this._increment(r, c + 1);

          this._increment(r + 1, c - 1);
          this._increment(r + 1, c);
          this._increment(r + 1, c + 1);
        }
      }
    }
  }

}