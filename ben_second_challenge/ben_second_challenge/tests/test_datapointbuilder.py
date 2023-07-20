from srcs.data_point_builder import DataPointBuilder

class TestClass:
	def test_default_id_return(self):
		databuilder = DataPointBuilder()
		id = databuilder.id()
		assert isinstance(id, int) == True

	def test_default_id_lesser_than_longmax(self):
		for _ in range(100):
			databuilder = DataPointBuilder(long_max=2)
			id = databuilder.id()
			assert id < 2
