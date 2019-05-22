
public partial class BootcampService : ServiceBase
    {
        Bootcamp bootcamp;
 
        public BootcampService()
        {
            InitializeComponent();
        }
 
        protected override void OnStart(string[] args)
        {
            bootcamp = new Bootcamp( args[0],args[1] );         
        }
 
        protected override void OnStop()
        {

        }

        public void setX( int width) {

            this.bootcamp.setX(width);
            
          }

        public int getX() {

            return this.bootcamp.getX();
          
          }

        public void setY(int height) {

            this.bootcamp.setY(height);

          }

        public int getY(){

            return this.bootcamp.getY();
          }


        public int[,] getCamp(){

            return this.bootcamp.getCamp();
          }

        public string display(int x, int y){

           return this.bootcamp.display(x,y);
          }

        public void changeBomb(int x, int y) {

            this.bootcamp.changeBomb(x,y);
         }

        public void setBomb(int x, int y){

            this.bootcamp.setBomb(x,y);
          }

        public void clear(int x, int y){

            this.bootcamp.clear(x,y);
          }

}


