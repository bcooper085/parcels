namespace Parcel.Objects
{
  public class ParcelVariables
  {
    private int _length;
    private int _width;
    private int _height;
    private int _weight;
    private int _volume;

    public int GetLength()
    {
      return _length;
    }

    public int GetWidth()
    {
      return _width;
    }

    public int GetHeight()
    {
      return _height;
    }

    public int GetWeight()
    {
      return _weight;
    }

    public int GetVolume()
    {
      return _volume =  _length * _width * _height;
    }

    public void SetLength(int newLength)
    {
      _length = newLength;
    }

    public void SetWidth(int newWidth)
    {
      _width = newWidth;
    }

    public void SetHeight(int newHeight)
    {
      _height = newHeight;
    }

    public void SetWeight(int newWeight)
    {
      _weight = newWeight;
    }

    public void setVolume()
    {
      _volume;
    }

    public int CostToShip()
    {
      if (_weight <= 1)
      {
        return 5;
      }
      else if (_weight > 1 && _weight <= 5)
      {
        return 10;
      }
      else if (_weight > 5 && _weight <= 10)
      {
        return 15;
      }
      else
      {
        return 20;
      }
    }
  }
}
