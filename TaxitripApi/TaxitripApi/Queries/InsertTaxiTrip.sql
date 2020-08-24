﻿INSERT INTO taxi_trips
(`vendor_id`,
`tpep_pickup_datetime`,
`tpep_dropoff_datetime`,
`passenger_count`,
`trip_distance`,
`pickup_longitude`,
`pickup_latitude`,
`rate_code_id`,
`store_and_fwd_flag`,
`dropoff_longitude`,
`payment_type`,
`fare_amount`,
`extra`,
`mta_tax`,
`tip_amount`,
`tolls_amount`,
`improvement_surcharge`,
`total_amount`)
VALUES
(@vendor_id }>,
<{tpep_pickup_datetime: }>,
<{tpep_dropoff_datetime: }>,
<{passenger_count: }>,
<{trip_distance: }>,
<{pickup_longitude: }>,
<{pickup_latitude: }>,
<{rate_code_id: }>,
<{store_and_fwd_flag: }>,
<{dropoff_longitude: }>,
<{payment_type: }>,
<{fare_amount: }>,
<{extra: }>,
<{mta_tax: }>,
<{tip_amount: }>,
<{tolls_amount: }>,
<{improvement_surcharge: }>,
<{total_amount: }>);
