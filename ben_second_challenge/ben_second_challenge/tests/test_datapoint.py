from srcs.data_point import DataPoint
from srcs.data_point_builder import DataPointBuilder

class TestClass:
    def test_default_data_point_return(self):
        new_data_point = DataPoint(DataPointBuilder())
        assert isinstance(new_data_point._id, int) == True
        assert isinstance(new_data_point._consumer_unity, str) == True
        assert isinstance(new_data_point._value, float) == True
        assert isinstance(new_data_point._date, float) == True