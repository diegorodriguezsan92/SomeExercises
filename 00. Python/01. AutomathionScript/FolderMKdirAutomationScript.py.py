import calendar
from pathlib import Path

months_year = list(calendar.month_name[1:])
mdays = [n for n in range(1,32)]

for i, month in enumerate(months_year):
    for day in mdays:
        Path(f'2022/{i+1}. {month}/{day}').mkdir(parents=True, exist_ok=True)
        fac = calendar