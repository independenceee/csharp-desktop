private int ImageNumber = 1;


        private void LoadImage() 
        {
            if(ImageNumber == 8) {
                ImageNumber = 1; 
            }
            SliderPicture.ImageLocation = string.Format(@"images/background-{0}.jpg", ImageNumber);
            ImageNumber++;

        }
        private void SilderBackGround_Tick(object sender, EventArgs e)
        {
            LoadImage();
        }