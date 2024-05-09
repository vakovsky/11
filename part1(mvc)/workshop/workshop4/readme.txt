bool left = true;

private void timer1_Tick(object sender, EventArgs e)
{
  if (pictureBox1.Left >= 0 && left)
  {
      pictureBox1.Left -= 20;
  }
  else
  {
      left = false;
  }
  if (pictureBox1.Right <= ClientSize.Width && !left)
  {
      pictureBox1.Left += 20;
  }
  else
  {
      left = true;
  }
}

private void Form1_KeyUp(object sender, KeyEventArgs e)
{
  if (e.KeyCode == Keys.Left)
  {

  }
  if (e.KeyCode == Keys.Right)
  {

  }
  if (e.KeyCode == Keys.Up)
  {

  }
  if (e.KeyCode == Keys.Down)
  {

  }
  if(e.KeyCode == Keys.Space)
  {

  }
}
