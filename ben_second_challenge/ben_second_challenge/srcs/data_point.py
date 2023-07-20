class DataPoint:
	"""
	"""

	def __init__(self, builder):
		"""
		Args:
		"""

		self._id = builder.id()
		self._value = builder.value()
		self._date = builder.date()
		self._status = builder.status()

	def to_dict(self):
		"""
		Convert the current object to a dictionary

		Returns:
			Dictionary: a dictionary representation of class with variable name as key and the variable value as value.
		"""

		return { 
			"dataPointId": self._id,
            "value": self._value,
            "date": self._date,
			"status": self._status
		   }