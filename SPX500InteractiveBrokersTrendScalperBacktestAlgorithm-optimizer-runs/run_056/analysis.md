# SPX500 IB Trend Scalper Analysis

- Metrics file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_056/execution-metrics.csv`
- Backtest file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_056/launcher/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm.json`
- Completed paired trades: 88
- Entry signals: 88
- Approx open/unpaired entry signals: 0
- Position/order maintenance waits: 5936
- Total paired trade PnL: 6204.20
- Win rate: 100.0%
- Realized loss trades: 0
- Median hold: 12.0 minutes
- Average hold: 16.9 minutes

## Lean Runtime Statistics
- Equity: $106,204.20
- Net Profit: $6,204.20
- Return: 6.20 %
- Probabilistic Sharpe Ratio: 100%
- Volume: $38,333,708.20

## Risk And Efficiency
- Exposure hours: 24.7
- PnL per exposure hour: 250.98
- Calendar span days: 12.3
- PnL per calendar day: 504.05
- Trades per calendar day: 7.15
- Exposure share of calendar time: 8.4%
- Growth quality score: 10032.9
- VIX stale at entry: 0.0%
- ES stale rows: 9.6%
- Waiting ES VWAP rows: 0.0%
- Trade-health exit signals: 0
- Trade-health tighten signals: 0
- Slow trades held >= 12 hours: 0 (0.0%)
- Slow exposure hours: 0.0
- Slow PnL per exposure hour: 
- Fast <15m trades: 57
- Fast PnL per exposure hour: 703.77

## Pullback Broken Structure Veto
- Blocked signal rows: 1334
- Blocked by profile: `{"charm_pin_pullback_long": 1278, "pullback_long": 56}`
- Blocked net profit / worst MAE: not available for hard-blocked signals because they do not become completed trades.
- Remaining trades by profile: `{"breakout_long_1dte": 12, "breakout_long_no_0dte": 3, "call_wall_acceptance_long": 1, "charm_pin_pullback_long": 28, "charm_wall_breakaway_long": 5, "pullback_long": 28, "pullback_long_no_0dte": 3, "squeeze_long": 8}`
- Remaining PnL by profile: `{"breakout_long_1dte": 621.0000000000127, "breakout_long_no_0dte": 284.50000000001273, "call_wall_acceptance_long": 546.0, "charm_pin_pullback_long": 1088.200000000108, "charm_wall_breakaway_long": 573.9999999999873, "pullback_long": 2303.4000000001233, "pullback_long_no_0dte": 147.59999999998035, "squeeze_long": 639.5}`

## Lean Portfolio And Trade Statistics
- Portfolio: sharpeRatio=29.1828, sortinoRatio=0, alpha=0, beta=0, informationRatio=29.8886, drawdown=0.007
- Trades: sharpeRatio=0.9134, averageMAE=-99.6273, averageMFE=90.4426, largestMAE=-655.2, largestMFE=592.8, maximumIntraTradeDrawdown=-1248.0

## Strategy Profile Performance

| Strategy | Enabled | Data State | Profile Set | Trades | PnL | Avg PnL | Win Rate | Median Hold Min | Exposure Hrs | PnL/Exposure Hr | Slow >=12h | Worst MAE | Median MFE | Median TP |
| --- | --- | --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| pullback_long | true | VALID_0DTE | VALID_0DTE | 28 | 2303.40 | 82.26 | 100.0% | 8.6 | 6.8 | 338.36 | 0 | -279.00 | 108.00 | 3.28 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 28 | 1088.20 | 38.86 | 100.0% | 4.8 | 5.1 | 213.79 | 0 | -335.75 | 42.50 | 2.40 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 8 | 639.50 | 79.94 | 100.0% | 13.1 | 2.7 | 238.64 | 0 | -208.25 | 77.78 | 33.59 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 12 | 621.00 | 51.75 | 100.0% | 25.2 | 4.5 | 139.30 | 0 | -369.25 | 79.88 | 3.00 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 5 | 574.00 | 114.80 | 100.0% | 14.7 | 1.1 | 503.63 | 0 | -357.00 | 95.40 | 12.00 |
| call_wall_acceptance_long | true | VALID_0DTE | VALID_0DTE | 1 | 546.00 | 546.00 | 100.0% | 120.4 | 2.0 | 272.13 | 0 | -655.20 | 592.80 | 20.95 |
| breakout_long_no_0dte | true | EXPIRED_0DTE | EXPIRED_0DTE | 1 | 213.50 | 213.50 | 100.0% | 14.7 | 0.2 | 870.44 | 0 | -78.75 | 250.25 | 6.00 |
| pullback_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 3 | 147.60 | 49.20 | 100.0% | 11.9 | 0.5 | 273.33 | 0 | -26.10 | 55.80 | 4.00 |
| breakout_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 2 | 71.00 | 35.50 | 100.0% | 52.6 | 1.8 | 40.51 | 0 | -250.25 | 62.27 | 6.00 |
| breakout_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| wall_reclaim_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| wall_breakout_retest_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| late_day_pin_fade | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| negative_gamma_momentum_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| trend_day_pullback_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| breakout_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| pullback_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| squeeze_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |

## Strategy Entry Fingerprints

| Strategy | Enabled | Data State | Profile Set | Trades | Median Setup | Median ES-VWAP | Median RSI | Median ADX | Avg Hold Min | Slow >=12h |
| --- | --- | --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| pullback_long | true | VALID_0DTE | VALID_0DTE | 28 | 50.07 | 6.57 | 47.87 | 18.52 | 14.6 | 0 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 28 | 66.78 | 29.70 | 47.61 | 18.82 | 10.9 | 0 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 8 | 70.77 | 12.97 | 71.46 | 21.69 | 20.1 | 0 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 12 | 78.63 | 7.58 | 74.48 | 31.59 | 22.3 | 0 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 5 | 78.51 | 21.06 | 69.26 | 16.86 | 13.7 | 0 |
| call_wall_acceptance_long | true | VALID_0DTE | VALID_0DTE | 1 | 73.44 | 28.76 | 54.73 | 14.45 | 120.4 | 0 |
| breakout_long_no_0dte | true | EXPIRED_0DTE | EXPIRED_0DTE | 1 | 70.88 | 7.38 | 81.57 | 27.17 | 14.7 | 0 |
| pullback_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 3 | 45.09 | 5.48 | 48.15 | 17.78 | 10.8 | 0 |
| breakout_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 2 | 78.32 | 11.24 | 80.45 | 28.97 | 52.6 | 0 |
| breakout_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| wall_reclaim_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| wall_breakout_retest_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| late_day_pin_fade | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| negative_gamma_momentum_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| trend_day_pullback_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| breakout_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 |  |  |  |  |  | 0 |
| pullback_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 |  |  |  |  |  | 0 |
| squeeze_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 |  |  |  |  |  | 0 |

## MAE And MFE
- MAE: average -101.94, median -69.53, worst -655.20
- MFE: average 90.44, median 69.03, best 592.80
- Average MFE / absolute MAE: 0.89

## Intratrade Path
- Trades with path stats: 88; with intratrade price samples: 88
- Went positive before max adverse: 51.1%
- MFE happened before MAE: 12.5%
- TP touched before MAE: 1.1%
- Median MFE available before MAE: 0.05 points
- Median first TP touch: 3.8 minutes
- Median first +1.5 points: 2.5 minutes
- First 15m MFE/MAE medians: 2.40 / -1.92 points

## Worst Tail Trade Autopsy
- Worst tail entry: `2026-06-26T11:59:48+00:00` -> `2026-06-26T14:00:11+00:00`.
- Strategy/profile: `call_wall_acceptance_long` / `call_wall_acceptance_long`. PnL 546.00, MAE -655.20, MFE 592.80, hold 120.4 minutes.
- Profile context: `call_wall_acceptance_long` produced 1 trades, PnL 546.00, 0 slow >=12h trades, and 8.8% of total PnL.
- Entry state: setup=73.44, ES-VWAP=28.76, VWAP slope=0.0302, VWAP acceleration=-0.0176, RSI=54.73, ADX=14.45, structure score=5.00, higher-low=4.25, higher-high=3.00, pullback-from-high=4.50, rolling-high distance=4.50.
- Guard state: setup allowed=`True`, entry veto allowed=`True`, veto points=2.00, slow-risk points=0.00.
- Existing warning reason: RSI slope -2.5746 <= -2.0000; ADX 14.45 <= 18.00.
- Strategy selection reason: positive gamma call-wall acceptance: callPutVolumeImbalance=0.8914, callWall=7400.00, target=7458.20, distance=14.50, forwardDexRatio30m=0.6066.
- Intratrade path: path MFE 21.00, path MAE -22.70, MFE before MAE=`False`, TP reached=`True`.
- Surgical setup floor check: `setup_quality_score >= 73.5` would block this trade, keep 23 trades, retain 24.9% PnL, and leave worst MAE -369.25. It would block 65 trades total.
- No single candidate threshold in the report cleanly removes this tail; the closest visible guard is setup quality 73.44.

## Unscanned Feature Coverage
- Present trade columns: 144, scanned columns: 144, unscanned columns: 0
- No unscanned feature columns found. Good coverage for all present trade fields.

## Candidate Entry Quality Filters

| Scope | Condition | Kept | Blocked | Kept PnL | PnL Loss | Retained PnL | Slow Removed | Slow Left | Kept PnL/Exposure Hr | Kept Worst MAE | Score |
| --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| all | No useful single-threshold candidate found |  |  |  |  |  |  |  |  |  |  |

## Hidden MAE Signature Candidates

| Condition | Bad Trades | Bad Blocked | Good Blocked | Kept Trades | Kept PnL | PnL Loss | Retained PnL | Kept Worst MAE | Score |
| --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| `long_strategy != "breakout_long_1dte"` | 17 | 4 | 8 | 76 | 5583.20 | 621.00 | 90.0% | -655.20 | 15875.3 |
| `strategy_profile != "breakout_long_1dte"` | 17 | 4 | 8 | 76 | 5583.20 | 621.00 | 90.0% | -655.20 | 15875.3 |
| `es_structure_rising_vwap != "False"` | 17 | 4 | 8 | 76 | 5232.20 | 972.00 | 84.3% | -655.20 | 15805.1 |
| `path_half_tp_touch_minutes >= 0.616667` | 17 | 8 | 27 | 53 | 4424.00 | 1780.20 | 71.3% | -655.20 | 297.9 |
| `path_half_tp_touch_minutes >= 0.183333` | 17 | 7 | 20 | 61 | 4788.00 | 1416.20 | 77.2% | -655.20 | 291.6 |
| `es_structure_higher_low_distance >= -1` | 17 | 5 | 14 | 69 | 5092.00 | 1112.20 | 82.1% | -655.20 | 190.6 |
| `es_structure_vwap_slope <= 0.0557657` | 17 | 6 | 21 | 61 | 4463.10 | 1741.10 | 71.9% | -655.20 | 149.2 |
| `option_strike_map_next_upside_call_volume_distance >= 3.25` | 17 | 6 | 24 | 58 | 4422.90 | 1781.30 | 71.3% | -655.20 | 137.5 |
| `path_first_observed_points >= -0.75` | 17 | 4 | 4 | 80 | 5150.90 | 1053.30 | 83.0% | -362.25 | 133.8 |
| `path_first_nonzero_move_points >= -0.75` | 17 | 4 | 4 | 80 | 5150.90 | 1053.30 | 83.0% | -362.25 | 133.8 |
| `es_structure_higher_low_distance >= -1.25` | 17 | 4 | 12 | 72 | 5202.80 | 1001.40 | 83.9% | -655.20 | 131.2 |
| `option_strike_map_next_upside_call_volume_distance >= 3` | 17 | 5 | 21 | 62 | 4655.60 | 1548.60 | 75.0% | -655.20 | 101.5 |

## Upside TP Extension Candidates
| all | No upside TP extension candidates found. |  |  |  |  |  |  |  |  |  |  |

## Event Counts
- blocked: 38343
- position_wait: 5936
- stale_es_vwap: 4867
- waiting_spx_quote: 414
- trade_risk_tighten_signal: 413
- order_event: 397
- trade_risk_extend_signal: 312
- entry_signal: 88

## Blocked Gate Counts
- setup_quality_allowed: 15061 (disabled=15061)
- above_vwap_confirmed: 9396 (disabled=9396)
- above_vwap: 8378 (disabled=8378)
- es_structure_allowed: 8131 (disabled=8131)
- pullback: 6899 (disabled=6899)
- momentum: 4428 (disabled=4428)
- es_vwap_max_distance_allowed: 4145 (disabled=4145)
- es_vwap_slope_allowed: 3844 (disabled=3844)
- trend_strength: 3490 (disabled=3490)
- es_vwap_acceleration_allowed: 1998 (disabled=1998)
- es_rolling_high_allowed: 506 (disabled=506)
- indicator_slope_allowed: 175 (disabled=175)

## By UTC Hour

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 8 | 12 | 1009.50 | 84.13 | 100.0% | 13.3 |
| 13 | 11 | 692.40 | 62.95 | 100.0% | 0.4 |
| 14 | 10 | 853.30 | 85.33 | 100.0% | 2.1 |
| 9 | 9 | 472.40 | 52.49 | 100.0% | 12.0 |
| 11 | 5 | 707.20 | 141.44 | 100.0% | 12.0 |
| 15 | 5 | 327.30 | 65.46 | 100.0% | 11.9 |
| 6 | 5 | 309.80 | 61.96 | 100.0% | 12.0 |
| 12 | 4 | 170.80 | 42.70 | 100.0% | 12.4 |
| 22 | 4 | 399.00 | 99.75 | 100.0% | 14.9 |
| 18 | 3 | 212.30 | 70.77 | 100.0% | 8.8 |
| 19 | 3 | 198.30 | 66.10 | 100.0% | 8.4 |
| 7 | 3 | 205.70 | 68.57 | 100.0% | 12.0 |
| 0 | 2 | 143.50 | 71.75 | 100.0% | 26.9 |
| 1 | 2 | 72.00 | 36.00 | 100.0% | 21.5 |
| 10 | 2 | 55.40 | 27.70 | 100.0% | 18.4 |
| 23 | 2 | 70.00 | 35.00 | 100.0% | 29.0 |
| 3 | 2 | 114.00 | 57.00 | 100.0% | 20.7 |
| 5 | 2 | 81.50 | 40.75 | 100.0% | 22.1 |
| 2 | 1 | 36.00 | 36.00 | 100.0% | 25.5 |
| 4 | 1 | 73.80 | 73.80 | 100.0% | 4.2 |

## By RSI Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <55 | 50 | 3736.30 | 74.73 | 100.0% | 6.6 |
| 55-60 | 9 | 556.40 | 61.82 | 100.0% | 12.0 |
| 70-75 | 8 | 413.00 | 51.62 | 100.0% | 20.3 |
| >=75 | 8 | 615.50 | 76.94 | 100.0% | 14.9 |
| 65-70 | 7 | 648.00 | 92.57 | 100.0% | 15.7 |
| 60-65 | 6 | 235.00 | 39.17 | 100.0% | 27.5 |

## By ADX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <20 | 42 | 3112.60 | 74.11 | 100.0% | 7.8 |
| 20-25 | 15 | 1281.60 | 85.44 | 100.0% | 9.4 |
| 30-40 | 15 | 962.10 | 64.14 | 100.0% | 12.0 |
| 25-30 | 11 | 639.50 | 58.14 | 100.0% | 23.3 |
| 40-50 | 4 | 169.90 | 42.47 | 100.0% | 32.5 |
| >=50 | 1 | 38.50 | 38.50 | 100.0% | 17.0 |

## By VIX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| missing | 88 | 6204.20 | 70.50 | 100.0% | 12.0 |

## By ES VWAP Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.25 | 83 | 5586.70 | 67.31 | 100.0% | 12.0 |
| 0.25-0.5 | 3 | 564.50 | 188.17 | 100.0% | 9.4 |
| -0.25-0 | 1 | 36.00 | 36.00 | 100.0% | 56.0 |
| 0.5-1 | 1 | 17.00 | 17.00 | 100.0% | 29.9 |

## By ES VWAP Acceleration Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.05 | 32 | 1816.80 | 56.78 | 100.0% | 12.0 |
| -0.05-0 | 31 | 2561.80 | 82.64 | 100.0% | 7.1 |
| 0.1-0.25 | 11 | 1079.80 | 98.16 | 100.0% | 14.7 |
| 0.05-0.1 | 10 | 515.30 | 51.53 | 100.0% | 25.2 |
| >=0.25 | 2 | 53.00 | 26.50 | 100.0% | 55.9 |
| -0.1--0.05 | 1 | 90.00 | 90.00 | 100.0% | 9.7 |
| -0.25--0.1 | 1 | 87.50 | 87.50 | 100.0% | 6.7 |

## By ES Rolling High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-6 | 28 | 2063.40 | 73.69 | 100.0% | 2.6 |
| 2-4 | 19 | 1091.60 | 57.45 | 100.0% | 12.0 |
| 0-1 | 11 | 909.50 | 82.68 | 100.0% | 14.7 |
| 6-8 | 9 | 742.80 | 82.53 | 100.0% | 12.1 |
| 1-2 | 8 | 544.70 | 68.09 | 100.0% | 22.0 |
| 8-12 | 6 | 285.10 | 47.52 | 100.0% | 13.0 |
| 12-20 | 5 | 496.10 | 99.22 | 100.0% | 6.6 |
| >=20 | 2 | 71.00 | 35.50 | 100.0% | 37.6 |

## By ES Rolling High Minutes Since

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 20-30 | 24 | 1594.30 | 66.43 | 100.0% | 6.6 |
| <1 | 21 | 1395.20 | 66.44 | 100.0% | 16.6 |
| 10-20 | 13 | 725.20 | 55.78 | 100.0% | 12.0 |
| 5-10 | 12 | 1242.50 | 103.54 | 100.0% | 9.2 |
| 3-5 | 10 | 502.90 | 50.29 | 100.0% | 10.2 |
| 1-3 | 8 | 744.10 | 93.01 | 100.0% | 14.7 |

## By RSI Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| >=3 | 24 | 1820.00 | 75.83 | 100.0% | 14.4 |
| 0-1 | 16 | 734.60 | 45.91 | 100.0% | 12.0 |
| <-3 | 10 | 540.90 | 54.09 | 100.0% | 9.5 |
| -3--2 | 9 | 947.80 | 105.31 | 100.0% | 8.4 |
| -1-0 | 6 | 444.30 | 74.05 | 100.0% | 13.3 |
| 1-2 | 6 | 507.80 | 84.63 | 100.0% | 8.1 |
| 2-3 | 6 | 341.50 | 56.92 | 100.0% | 14.2 |
| missing | 6 | 441.40 | 73.57 | 100.0% | 8.4 |
| -2--1 | 5 | 425.90 | 85.18 | 100.0% | 8.8 |

## By ADX Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| -1-0 | 32 | 2655.70 | 82.99 | 100.0% | 12.0 |
| 0-1 | 31 | 2112.30 | 68.14 | 100.0% | 14.7 |
| 1-2 | 15 | 837.40 | 55.83 | 100.0% | 11.5 |
| missing | 6 | 441.40 | 73.57 | 100.0% | 8.4 |
| -2--1 | 4 | 157.40 | 39.35 | 100.0% | 12.0 |

## By ES Higher-Low Distance Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 2-4 | 25 | 2070.90 | 82.84 | 100.0% | 8.7 |
| >=8 | 17 | 1156.50 | 68.03 | 100.0% | 14.7 |
| 1-2 | 15 | 781.70 | 52.11 | 100.0% | 2.3 |
| 4-8 | 14 | 1277.30 | 91.24 | 100.0% | 12.4 |
| 0-0.5 | 10 | 466.20 | 46.62 | 100.0% | 4.5 |
| 0.5-1 | 7 | 451.60 | 64.51 | 100.0% | 11.9 |

## By ES Structure Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 3 | 30 | 2030.30 | 67.68 | 100.0% | 10.8 |
| 5 | 29 | 2171.50 | 74.88 | 100.0% | 11.9 |
| 4 | 28 | 1968.40 | 70.30 | 100.0% | 12.0 |
| 2 | 1 | 34.00 | 34.00 | 100.0% | 12.1 |

## By ES Structure Pullback From High

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-2 | 30 | 2194.60 | 73.15 | 100.0% | 14.4 |
| 2-4 | 30 | 1738.70 | 57.96 | 100.0% | 11.9 |
| 4-8 | 23 | 2020.80 | 87.86 | 100.0% | 8.4 |
| 8-12 | 4 | 160.10 | 40.02 | 100.0% | 14.7 |
| 12-16 | 1 | 90.00 | 90.00 | 100.0% | 9.7 |

## By ES Structure Higher-Low Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 34 | 2235.80 | 65.76 | 100.0% | 12.0 |
| 2-4 | 12 | 560.50 | 46.71 | 100.0% | 11.7 |
| 0.5-1 | 10 | 767.70 | 76.77 | 100.0% | 7.1 |
| 1-2 | 9 | 641.70 | 71.30 | 100.0% | 12.8 |
| 4-8 | 9 | 848.60 | 94.29 | 100.0% | 15.0 |
| >=8 | 8 | 700.50 | 87.56 | 100.0% | 12.0 |
| 0-0.5 | 6 | 449.40 | 74.90 | 100.0% | 5.4 |

## By ES Structure Higher-High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 32 | 1941.90 | 60.68 | 100.0% | 7.2 |
| 2-4 | 19 | 1723.10 | 90.69 | 100.0% | 12.2 |
| 4-8 | 12 | 676.40 | 56.37 | 100.0% | 20.1 |
| >=8 | 10 | 830.00 | 83.00 | 100.0% | 13.4 |
| 1-2 | 8 | 623.80 | 77.98 | 100.0% | 10.8 |
| 0-0.5 | 4 | 192.10 | 48.03 | 100.0% | 16.9 |
| 0.5-1 | 3 | 216.90 | 72.30 | 100.0% | 8.8 |

## By ES Structure VWAP Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 25 | 1965.20 | 78.61 | 100.0% | 12.8 |
| >=24 | 25 | 1392.60 | 55.70 | 100.0% | 2.3 |
| 8-12 | 14 | 865.80 | 61.84 | 100.0% | 19.0 |
| 12-16 | 9 | 834.00 | 92.67 | 100.0% | 12.0 |
| 2-4 | 6 | 368.60 | 61.43 | 100.0% | 18.4 |
| 16-24 | 5 | 553.10 | 110.62 | 100.0% | 12.0 |
| 0-2 | 4 | 224.90 | 56.22 | 100.0% | 11.9 |

## By Setup Quality Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 50-60 | 28 | 1768.20 | 63.15 | 100.0% | 6.6 |
| 70-80 | 19 | 2195.50 | 115.55 | 100.0% | 12.0 |
| 60-70 | 15 | 526.10 | 35.07 | 100.0% | 12.0 |
| 40-50 | 14 | 1170.20 | 83.59 | 100.0% | 8.6 |
| 80-90 | 12 | 544.20 | 45.35 | 100.0% | 18.9 |

## By Entry-Veto Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 3-4 | 20 | 1332.40 | 66.62 | 100.0% | 10.3 |
| 1-2 | 18 | 1238.60 | 68.81 | 100.0% | 13.8 |
| 2-3 | 18 | 1258.50 | 69.92 | 100.0% | 15.6 |
| 4-5 | 16 | 1314.50 | 82.16 | 100.0% | 5.6 |
| 5-6 | 13 | 714.90 | 54.99 | 100.0% | 7.2 |
| <1 | 3 | 345.30 | 115.10 | 100.0% | 12.0 |

## By Slow-Risk Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <1 | 88 | 6204.20 | 70.50 | 100.0% | 12.0 |

## By Entry Risk Tier

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| standard | 88 | 6204.20 | 70.50 | 100.0% | 12.0 |

## By ES Reclaim Current Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 25 | 1965.20 | 78.61 | 100.0% | 12.8 |
| >=24 | 25 | 1392.60 | 55.70 | 100.0% | 2.3 |
| 8-12 | 14 | 865.80 | 61.84 | 100.0% | 19.0 |
| 12-16 | 9 | 834.00 | 92.67 | 100.0% | 12.0 |
| 2-4 | 6 | 368.60 | 61.43 | 100.0% | 18.4 |
| 16-24 | 5 | 553.10 | 110.62 | 100.0% | 12.0 |
| 0-2 | 4 | 224.90 | 56.22 | 100.0% | 11.9 |

## By SPX EMA20 Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 60 | 3959.20 | 65.99 | 100.0% | 8.4 |
| 2-4 | 9 | 368.00 | 40.89 | 100.0% | 24.9 |
| 4-6 | 5 | 337.00 | 67.40 | 100.0% | 12.0 |
| 8-12 | 5 | 656.20 | 131.24 | 100.0% | 12.1 |
| >=12 | 5 | 231.80 | 46.36 | 100.0% | 16.6 |
| 6-8 | 2 | 70.00 | 35.00 | 100.0% | 40.7 |
| 0-1 | 1 | 546.00 | 546.00 | 100.0% | 120.4 |
| 1-2 | 1 | 36.00 | 36.00 | 100.0% | 25.5 |

## By Hold-Time Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 5-15 | 36 | 3315.90 | 92.11 | 100.0% | 11.9 |
| 15-30 | 22 | 713.40 | 32.43 | 100.0% | 20.9 |
| <5 | 21 | 1337.40 | 63.69 | 100.0% | 0.8 |
| 30-60 | 5 | 177.00 | 35.40 | 100.0% | 42.2 |
| 60-180 | 4 | 660.50 | 165.12 | 100.0% | 101.3 |

## By VIX Regime

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| disabled | 88 | 6204.20 | 70.50 | 100.0% | 12.0 |

## By Option Data State

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 70 | 5151.10 | 73.59 | 100.0% | 10.8 |
| VALID_1DTE_ONLY | 12 | 621.00 | 51.75 | 100.0% | 25.2 |
| STALE_0DTE | 5 | 218.60 | 43.72 | 100.0% | 16.4 |
| EXPIRED_0DTE | 1 | 213.50 | 213.50 | 100.0% | 14.7 |

## By Active Profile Set

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 70 | 5151.10 | 73.59 | 100.0% | 10.8 |
| VALID_1DTE_ONLY | 12 | 621.00 | 51.75 | 100.0% | 25.2 |
| STALE_0DTE | 5 | 218.60 | 43.72 | 100.0% | 16.4 |
| EXPIRED_0DTE | 1 | 213.50 | 213.50 | 100.0% | 14.7 |

## Monthly Summary

| Month | Trades | PnL | Avg PnL | Median Hold Min | Exposure Hours | PnL/Exposure Hour | Slow >=12h |
| --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| 2026-06 | 55 | 4121.90 | 74.94 | 11.9 | 14.0 | 294.84 | 0 |
| 2026-07 | 33 | 2082.30 | 63.10 | 12.0 | 10.7 | 193.90 | 0 |

## TP Target Distribution

| Target | Trades | PnL | Avg PnL | Median Hold Min |
| --- | ---: | ---: | ---: | ---: |
| 2.34 | 1 | 84.00 | 84.00 | 3.0 |
| 2.40 | 28 | 1088.20 | 38.86 | 4.8 |
| 2.49 | 1 | 45.50 | 45.50 | 20.6 |
| 2.57 | 1 | 93.60 | 93.60 | 5.3 |
| 2.63 | 1 | 39.60 | 39.60 | 12.0 |
| 2.83 | 1 | 36.00 | 36.00 | 56.0 |
| 2.92 | 1 | 112.20 | 112.20 | 7.1 |
| 2.99 | 1 | 105.00 | 105.00 | 8.5 |
| 3.00 | 12 | 621.00 | 51.75 | 25.2 |
| 3.02 | 1 | 36.00 | 36.00 | 90.2 |
| 3.09 | 1 | 55.80 | 55.80 | 11.9 |
| 3.13 | 1 | 59.50 | 59.50 | 12.0 |
| 3.14 | 1 | 108.50 | 108.50 | 6.5 |
| 3.19 | 1 | 35.00 | 35.00 | 26.0 |
| 3.22 | 1 | 118.80 | 118.80 | 6.6 |
| 3.25 | 1 | 118.80 | 118.80 | 0.9 |
| 3.26 | 1 | 118.80 | 118.80 | 3.8 |
| 3.30 | 1 | 118.80 | 118.80 | 0.1 |
| 3.31 | 1 | 35.00 | 35.00 | 19.1 |
| 3.35 | 1 | 119.00 | 119.00 | 8.4 |
| 3.43 | 1 | 46.80 | 46.80 | 12.7 |
| 3.46 | 1 | 136.50 | 136.50 | 8.8 |
| 3.48 | 1 | 122.50 | 122.50 | 5.8 |
| 3.51 | 1 | 35.00 | 35.00 | 17.4 |
| 3.56 | 1 | 36.00 | 36.00 | 15.6 |
| 3.58 | 1 | 36.00 | 36.00 | 23.6 |
| 3.60 | 5 | 506.50 | 101.30 | 7.1 |
| 4.00 | 2 | 91.80 | 45.90 | 10.3 |
| 6.00 | 3 | 284.50 | 94.83 | 23.3 |
| 12.00 | 5 | 574.00 | 114.80 | 14.7 |
| 14.06 | 1 | 34.00 | 34.00 | 12.1 |
| 16.25 | 1 | 35.00 | 35.00 | 23.6 |
| 20.95 | 1 | 546.00 | 546.00 | 120.4 |
| 23.75 | 1 | 35.00 | 35.00 | 57.7 |
| 28.44 | 1 | 112.20 | 112.20 | 12.0 |
| 38.75 | 2 | 125.80 | 62.90 | 14.7 |
| 48.62 | 1 | 35.00 | 35.00 | 14.0 |
| 53.41 | 1 | 262.50 | 262.50 | 12.0 |

## Slow Trade Fingerprint
- Trades held >= 12 hours: 0 (0.0%)

## Interpretation Notes
- This strategy exits with take-profit orders only, so a high win rate can hide capital being tied up for a long time.
- The best setting candidates are usually found by reducing slow-to-profit entries, not simply maximizing raw entry count.
- Focus first on buckets with low average PnL or long median hold time, then test stricter RSI/ADX/VWAP/VIX filters against those buckets.
