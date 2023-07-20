import random
import string
from datetime import datetime

class DataPointBuilder:
	"""
	This class maintain the configuration, rules
	and restrictions about every variable of the DataPoint object.
	"""

	def __init__(self,
		id_list_size = 10,
		long_max = 9223372036854775807,
		max_energy_value = 9999999,
		characters_allowed = string.ascii_letters + string.digits):
		"""
		Args:
		"""

		self._id_list_size = id_list_size
		self._long_max = long_max
		self._max_energy_value = max_energy_value
		self._id_list = [random.randrange(1, long_max) for _ in range(id_list_size)]

	def id(self):
		"""
		Choose a random id from the list of ids generated on construction.

		Returns:
			long: a random id as long
		"""

		return random.choice(self._id_list)

	def value(self):
		"""
		Create a random double value to represent the value field.

		Returns:
			double: a random value as double
		"""

		return round(random.uniform(1, self._max_energy_value), 2)

	def date(self):
		"""
		Create a random timestamp value to represent the date field.

		Returns:
			date: a random timestamp value as date
		"""
		return datetime.utcnow().isoformat()

	def status(self):
		return "OK"