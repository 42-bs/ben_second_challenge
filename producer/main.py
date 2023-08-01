from srcs.data_point_kafka_producer import DataPointKafkaProducer
import time
import os

if __name__ == "__main__":
	serverhost = os.getenv("KAFKA_HOST")
	print(serverhost)
	producer = DataPointKafkaProducer(server=serverhost, retry_limit=50)
	while (True):
		print("sending")
		producer.send_through_kafka()
		time.sleep(2)