from srcs.data_point_kafka_producer import DataPointKafkaProducer
import kafka
import kafka.errors
import pytest
from pytest import mark

class TestClass:
	global localhost
	localhost = False
	docker = False

	@mark.skipif(not localhost and not docker, reason="need to specify if server is on localhost or docker")
	def test_send_through_kafka(self):
		serverhost = 'localhost:9092' if localhost == True else 'kafka:9092' 
		producer = DataPointKafkaProducer(server=serverhost)
		msg = producer.send_through_kafka()
		with pytest.raises(kafka.errors.NotLeaderForPartitionError):
			metadata = msg.get(timeout=20)
			assert metadata.topic == 'random_data_point'