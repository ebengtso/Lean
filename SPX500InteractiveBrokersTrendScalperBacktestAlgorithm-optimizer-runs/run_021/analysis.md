# SPX500 IB Trend Scalper Analysis

- Metrics file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_021/execution-metrics.csv`
- Backtest file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_021/launcher/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm.json`
- Completed paired trades: 106
- Entry signals: 106
- Approx open/unpaired entry signals: 0
- Position/order maintenance waits: 8541
- Total paired trade PnL: 7041.60
- Win rate: 100.0%
- Realized loss trades: 0
- Median hold: 12.0 minutes
- Average hold: 20.9 minutes

## Lean Runtime Statistics
- Equity: $107,041.60
- Net Profit: $7,041.60
- Return: 7.04 %
- Probabilistic Sharpe Ratio: 100.000%
- Volume: $45,046,358.40

## Risk And Efficiency
- Exposure hours: 36.8
- PnL per exposure hour: 191.11
- Calendar span days: 12.3
- PnL per calendar day: 571.67
- Trades per calendar day: 8.61
- Exposure share of calendar time: 12.5%
- Growth quality score: 10999.2
- VIX stale at entry: 0.0%
- ES stale rows: 9.4%
- Waiting ES VWAP rows: 0.0%
- Trade-health exit signals: 0
- Trade-health tighten signals: 0
- Slow trades held >= 12 hours: 0 (0.0%)
- Slow exposure hours: 0.0
- Slow PnL per exposure hour: 
- Fast <15m trades: 66
- Fast PnL per exposure hour: 799.60

## Pullback Broken Structure Veto
- Blocked signal rows: 1214
- Blocked by profile: `{"charm_pin_pullback_long": 1162, "pullback_long": 52}`
- Blocked net profit / worst MAE: not available for hard-blocked signals because they do not become completed trades.
- Remaining trades by profile: `{"breakout_long_1dte": 20, "breakout_long_no_0dte": 3, "call_wall_acceptance_long": 1, "charm_pin_pullback_long": 37, "charm_wall_breakaway_long": 7, "pullback_long": 31, "pullback_long_no_0dte": 3, "squeeze_long": 4}`
- Remaining PnL by profile: `{"breakout_long_1dte": 1304.999999999991, "breakout_long_no_0dte": 278.40000000001237, "call_wall_acceptance_long": 91.0, "charm_pin_pullback_long": 1356.7000000001453, "charm_wall_breakaway_long": 1120.6000000000058, "pullback_long": 2429.1000000002377, "pullback_long_no_0dte": 91.79999999999018, "squeeze_long": 369.00000000001273}`

## Lean Portfolio And Trade Statistics
- Portfolio: sharpeRatio=30.1460, sortinoRatio=0, alpha=0, beta=0, informationRatio=30.7096, drawdown=0.005
- Trades: sharpeRatio=0.9997, averageMAE=-100.8476, averageMFE=83.8991, largestMAE=-638.75, largestMFE=462.60, maximumIntraTradeDrawdown=-682.50

## Strategy Profile Performance

| Strategy | Enabled | Data State | Profile Set | Trades | PnL | Avg PnL | Win Rate | Median Hold Min | Exposure Hrs | PnL/Exposure Hr | Slow >=12h | Worst MAE | Median MFE | Median TP |
| --- | --- | --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| pullback_long | true | VALID_0DTE | VALID_0DTE | 31 | 2429.10 | 78.36 | 100.0% | 12.0 | 12.5 | 194.23 | 0 | -638.75 | 106.20 | 3.35 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 37 | 1356.70 | 36.67 | 100.0% | 4.8 | 7.8 | 175.04 | 0 | -547.40 | 42.50 | 2.40 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 20 | 1305.00 | 65.25 | 100.0% | 14.1 | 7.7 | 168.76 | 0 | -375.70 | 79.88 | 3.00 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 7 | 1120.60 | 160.09 | 100.0% | 15.2 | 4.7 | 240.49 | 0 | -346.80 | 107.10 | 12.00 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 4 | 369.00 | 92.25 | 100.0% | 12.2 | 0.9 | 412.29 | 0 | -103.70 | 72.53 | 43.53 |
| breakout_long_no_0dte | true | EXPIRED_0DTE | EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 | 0.2 | 845.57 | 0 | -76.50 | 243.10 | 6.00 |
| pullback_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 3 | 91.80 | 30.60 | 100.0% | 16.4 | 1.1 | 83.22 | 0 | -103.50 | 27.90 | 4.00 |
| call_wall_acceptance_long | true | VALID_0DTE | VALID_0DTE | 1 | 91.00 | 91.00 | 100.0% | 12.0 | 0.2 | 455.00 | 0 | -11.70 | 131.30 | 28.66 |
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
| pullback_long | true | VALID_0DTE | VALID_0DTE | 31 | 50.03 | 6.71 | 49.20 | 21.81 | 24.2 | 0 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 37 | 68.64 | 29.56 | 51.23 | 20.52 | 12.6 | 0 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 20 | 66.60 | 5.83 | 70.56 | 26.99 | 23.2 | 0 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 7 | 75.96 | 14.42 | 69.38 | 19.86 | 39.9 | 0 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 4 | 69.56 | 12.13 | 62.70 | 20.38 | 13.4 | 0 |
| breakout_long_no_0dte | true | EXPIRED_0DTE | EXPIRED_0DTE | 1 | 70.88 | 7.38 | 81.57 | 27.17 | 14.7 | 0 |
| pullback_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 3 | 54.55 | 5.48 | 48.15 | 19.52 | 22.1 | 0 |
| call_wall_acceptance_long | true | VALID_0DTE | VALID_0DTE | 1 | 72.50 | 16.99 | 53.58 | 42.75 | 12.0 | 0 |
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
- MAE: average -101.81, median -59.50, worst -638.75
- MFE: average 83.90, median 55.95, best 462.60
- Average MFE / absolute MAE: 0.82

## Intratrade Path
- Trades with path stats: 106; with intratrade price samples: 106
- Went positive before max adverse: 47.2%
- MFE happened before MAE: 9.4%
- TP touched before MAE: 0.9%
- Median MFE available before MAE: 0.00 points
- Median first TP touch: 3.4 minutes
- Median first +1.5 points: 2.8 minutes
- First 15m MFE/MAE medians: 2.40 / -1.77 points

## Worst Tail Trade Autopsy
- Worst tail entry: `2026-07-01T06:48:37+00:00` -> `2026-07-01T09:56:31+00:00`.
- Strategy/profile: `pullback_long` / `pullback_long`. PnL 35.00, MAE -638.75, MFE 43.75, hold 187.9 minutes.
- Profile context: `pullback_long` produced 31 trades, PnL 2429.10, 0 slow >=12h trades, and 34.5% of total PnL.
- Entry state: setup=58.84, ES-VWAP=7.84, VWAP slope=0.0164, VWAP acceleration=-0.0021, RSI=55.24, ADX=29.83, structure score=3.00, higher-low=-2.00, higher-high=-1.25, pullback-from-high=1.25, rolling-high distance=3.75.
- Guard state: setup allowed=`True`, entry veto allowed=`True`, veto points=3.00, slow-risk points=0.00.
- Existing warning reason: ES structure score 3 <= 3; ES structure higher-low -2.00 < 0.25; ES structure higher-high -1.25 < 0.00.
- Strategy selection reason: VALID_0DTE ordered router; ordered ES pullback: trendPrice=7535.00, ema=7535.18, distance=7.84, adx=29.83, rsi=55.24, structure=3.
- Intratrade path: path MFE 1.25, path MAE -17.75, MFE before MAE=`False`, TP reached=`False`.
- Surgical setup floor check: `setup_quality_score >= 58.9` would block this trade, keep 59 trades, retain 52.4% PnL, and leave worst MAE -547.40. It would block 47 trades total.
- No single candidate threshold in the report cleanly removes this tail; the closest visible guard is setup quality 58.84.

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
| `long_strategy != "breakout_long_1dte"` | 21 | 6 | 14 | 86 | 5736.60 | 1305.00 | 81.5% | -638.75 | 15388.9 |
| `strategy_profile != "breakout_long_1dte"` | 21 | 6 | 14 | 86 | 5736.60 | 1305.00 | 81.5% | -638.75 | 15388.9 |
| `es_structure_rising_vwap != "False"` | 21 | 5 | 11 | 90 | 5782.50 | 1259.10 | 82.1% | -638.75 | 15348.3 |
| `path_half_tp_touch_minutes >= 0.183333` | 21 | 12 | 21 | 73 | 5443.20 | 1598.40 | 77.3% | -547.40 | 480.8 |
| `es_structure_higher_low_distance >= -1` | 21 | 6 | 17 | 83 | 5765.00 | 1276.60 | 81.9% | -403.20 | 144.7 |
| `path_first_observed_seconds <= 9` | 21 | 7 | 25 | 74 | 5347.00 | 1694.60 | 75.9% | -638.75 | 124.1 |
| `path_first_observed_seconds <= 10` | 21 | 6 | 20 | 80 | 5647.10 | 1394.50 | 80.2% | -638.75 | 119.0 |
| `path_first_observed_seconds <= 11` | 21 | 5 | 14 | 87 | 5948.10 | 1093.50 | 84.5% | -638.75 | 115.5 |
| `path_first_nonzero_move_seconds <= 10` | 21 | 6 | 21 | 79 | 5606.30 | 1435.30 | 79.6% | -638.75 | 110.1 |
| `path_first_nonzero_move_seconds <= 11` | 21 | 5 | 15 | 86 | 5907.30 | 1134.30 | 83.9% | -638.75 | 106.7 |
| `path_first_nonzero_move_seconds <= 9` | 21 | 7 | 27 | 72 | 5265.40 | 1776.20 | 74.8% | -638.75 | 106.5 |
| `es_structure_higher_low_distance >= -1.25` | 21 | 5 | 15 | 86 | 5858.80 | 1182.80 | 83.2% | -403.20 | 97.9 |

## Upside TP Extension Candidates
| all | No upside TP extension candidates found. |  |  |  |  |  |  |  |  |  |  |

## Event Counts
- blocked: 35738
- position_wait: 8541
- stale_es_vwap: 4867
- trade_risk_extend_signal: 1192
- trade_risk_tighten_signal: 485
- order_event: 476
- waiting_spx_quote: 415
- entry_signal: 106

## Blocked Gate Counts
- setup_quality_allowed: 14377 (disabled=14377)
- above_vwap_confirmed: 8908 (disabled=8908)
- above_vwap: 7989 (disabled=7989)
- es_structure_allowed: 7724 (disabled=7724)
- pullback: 6909 (disabled=6909)
- momentum: 4123 (disabled=4123)
- es_vwap_max_distance_allowed: 3898 (disabled=3898)
- es_vwap_slope_allowed: 3678 (disabled=3678)
- trend_strength: 3298 (disabled=3298)
- es_vwap_acceleration_allowed: 1690 (disabled=1690)
- es_rolling_high_allowed: 478 (disabled=478)
- indicator_slope_allowed: 169 (disabled=169)

## By UTC Hour

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 13 | 15 | 858.00 | 57.20 | 100.0% | 0.4 |
| 14 | 10 | 851.90 | 85.19 | 100.0% | 2.5 |
| 12 | 8 | 353.30 | 44.16 | 100.0% | 12.1 |
| 8 | 8 | 1149.70 | 143.71 | 100.0% | 14.3 |
| 1 | 6 | 512.20 | 85.37 | 100.0% | 3.0 |
| 15 | 6 | 368.10 | 61.35 | 100.0% | 9.2 |
| 18 | 6 | 337.60 | 56.27 | 100.0% | 10.4 |
| 9 | 6 | 324.80 | 54.13 | 100.0% | 14.0 |
| 11 | 5 | 174.80 | 34.96 | 100.0% | 13.3 |
| 19 | 5 | 252.40 | 50.48 | 100.0% | 17.0 |
| 5 | 5 | 245.10 | 49.02 | 100.0% | 20.6 |
| 6 | 5 | 232.60 | 46.52 | 100.0% | 16.4 |
| 2 | 4 | 211.40 | 52.85 | 100.0% | 48.6 |
| 22 | 4 | 393.90 | 98.48 | 100.0% | 14.9 |
| 0 | 3 | 174.40 | 58.13 | 100.0% | 12.1 |
| 7 | 3 | 203.00 | 67.67 | 100.0% | 12.1 |
| 10 | 2 | 58.90 | 29.45 | 100.0% | 17.6 |
| 23 | 2 | 70.00 | 35.00 | 100.0% | 29.5 |
| 3 | 2 | 150.50 | 75.25 | 100.0% | 15.9 |
| 17 | 1 | 119.00 | 119.00 | 100.0% | 7.3 |

## By RSI Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <55 | 56 | 3415.80 | 61.00 | 100.0% | 7.2 |
| 55-60 | 19 | 1372.80 | 72.25 | 100.0% | 15.3 |
| >=75 | 11 | 1009.50 | 91.77 | 100.0% | 9.9 |
| 60-65 | 7 | 351.70 | 50.24 | 100.0% | 8.4 |
| 65-70 | 7 | 627.00 | 89.57 | 100.0% | 15.2 |
| 70-75 | 6 | 264.80 | 44.13 | 100.0% | 18.7 |

## By ADX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <20 | 41 | 2774.20 | 67.66 | 100.0% | 8.4 |
| 20-25 | 22 | 1670.50 | 75.93 | 100.0% | 11.0 |
| 25-30 | 20 | 1180.80 | 59.04 | 100.0% | 12.1 |
| 30-40 | 16 | 948.90 | 59.31 | 100.0% | 12.6 |
| 40-50 | 6 | 427.60 | 71.27 | 100.0% | 8.4 |
| >=50 | 1 | 39.60 | 39.60 | 100.0% | 17.0 |

## By VIX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| missing | 106 | 7041.60 | 66.43 | 100.0% | 12.0 |

## By ES VWAP Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.25 | 102 | 6460.10 | 63.33 | 100.0% | 12.0 |
| 0.25-0.5 | 3 | 564.50 | 188.17 | 100.0% | 9.4 |
| 0.5-1 | 1 | 17.00 | 17.00 | 100.0% | 29.9 |

## By ES VWAP Acceleration Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.05 | 49 | 3074.90 | 62.75 | 100.0% | 12.3 |
| -0.05-0 | 40 | 2571.10 | 64.28 | 100.0% | 7.2 |
| 0.1-0.25 | 9 | 1002.70 | 111.41 | 100.0% | 14.7 |
| 0.05-0.1 | 5 | 252.40 | 50.48 | 100.0% | 17.3 |
| >=0.25 | 2 | 53.00 | 26.50 | 100.0% | 55.9 |
| -0.25--0.1 | 1 | 87.50 | 87.50 | 100.0% | 6.7 |

## By ES Rolling High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-6 | 27 | 1388.60 | 51.43 | 100.0% | 2.3 |
| 2-4 | 26 | 1348.00 | 51.85 | 100.0% | 12.6 |
| 0-1 | 19 | 1598.70 | 84.14 | 100.0% | 13.2 |
| 6-8 | 14 | 1408.40 | 100.60 | 100.0% | 14.6 |
| 8-12 | 9 | 526.30 | 58.48 | 100.0% | 12.0 |
| 1-2 | 5 | 288.00 | 57.60 | 100.0% | 20.6 |
| 12-20 | 5 | 448.60 | 89.72 | 100.0% | 6.6 |
| >=20 | 1 | 35.00 | 35.00 | 100.0% | 19.1 |

## By ES Rolling High Minutes Since

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 20-30 | 33 | 2398.50 | 72.68 | 100.0% | 7.3 |
| <1 | 23 | 1720.70 | 74.81 | 100.0% | 15.0 |
| 3-5 | 13 | 641.90 | 49.38 | 100.0% | 8.4 |
| 5-10 | 13 | 705.10 | 54.24 | 100.0% | 8.4 |
| 1-3 | 12 | 900.10 | 75.01 | 100.0% | 14.7 |
| 10-20 | 11 | 608.80 | 55.35 | 100.0% | 13.3 |
| 30-60 | 1 | 66.50 | 66.50 | 100.0% | 12.0 |

## By RSI Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| >=3 | 32 | 2493.70 | 77.93 | 100.0% | 12.2 |
| 0-1 | 21 | 990.30 | 47.16 | 100.0% | 13.3 |
| -3--2 | 10 | 405.40 | 40.54 | 100.0% | 4.1 |
| <-3 | 9 | 502.00 | 55.78 | 100.0% | 4.8 |
| -1-0 | 8 | 622.50 | 77.81 | 100.0% | 5.8 |
| -2--1 | 8 | 499.70 | 62.46 | 100.0% | 18.7 |
| 1-2 | 6 | 384.00 | 64.00 | 100.0% | 15.1 |
| 2-3 | 6 | 702.60 | 117.10 | 100.0% | 17.8 |
| missing | 6 | 441.40 | 73.57 | 100.0% | 8.4 |

## By ADX Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-1 | 40 | 2722.80 | 68.07 | 100.0% | 10.9 |
| -1-0 | 34 | 2479.60 | 72.93 | 100.0% | 12.5 |
| 1-2 | 19 | 1160.30 | 61.07 | 100.0% | 5.8 |
| -2--1 | 7 | 237.50 | 33.93 | 100.0% | 33.9 |
| missing | 6 | 441.40 | 73.57 | 100.0% | 8.4 |

## By ES Higher-Low Distance Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 2-4 | 34 | 1747.20 | 51.39 | 100.0% | 15.1 |
| 4-8 | 22 | 2309.20 | 104.96 | 100.0% | 12.0 |
| 1-2 | 21 | 1201.20 | 57.20 | 100.0% | 5.1 |
| >=8 | 12 | 897.30 | 74.78 | 100.0% | 13.5 |
| 0-0.5 | 9 | 425.60 | 47.29 | 100.0% | 7.1 |
| 0.5-1 | 8 | 461.10 | 57.64 | 100.0% | 10.3 |

## By ES Structure Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4 | 37 | 2435.50 | 65.82 | 100.0% | 13.3 |
| 3 | 34 | 2627.70 | 77.29 | 100.0% | 12.0 |
| 5 | 34 | 1944.40 | 57.19 | 100.0% | 8.6 |
| 2 | 1 | 34.00 | 34.00 | 100.0% | 12.1 |

## By ES Structure Pullback From High

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-2 | 44 | 3475.50 | 78.99 | 100.0% | 12.7 |
| 2-4 | 30 | 1674.10 | 55.80 | 100.0% | 10.1 |
| 4-8 | 26 | 1542.70 | 59.33 | 100.0% | 8.5 |
| 8-12 | 6 | 349.30 | 58.22 | 100.0% | 12.0 |

## By ES Structure Higher-Low Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 39 | 2757.80 | 70.71 | 100.0% | 12.3 |
| 2-4 | 20 | 730.40 | 36.52 | 100.0% | 12.7 |
| 4-8 | 13 | 645.00 | 49.62 | 100.0% | 9.9 |
| 0.5-1 | 10 | 928.40 | 92.84 | 100.0% | 4.8 |
| 1-2 | 10 | 832.20 | 83.22 | 100.0% | 12.5 |
| >=8 | 8 | 696.10 | 87.01 | 100.0% | 12.0 |
| 0-0.5 | 6 | 451.70 | 75.28 | 100.0% | 10.8 |

## By ES Structure Higher-High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 37 | 2636.00 | 71.24 | 100.0% | 8.7 |
| 2-4 | 20 | 1358.00 | 67.90 | 100.0% | 6.9 |
| 1-2 | 16 | 934.60 | 58.41 | 100.0% | 11.9 |
| 4-8 | 16 | 1127.00 | 70.44 | 100.0% | 12.1 |
| >=8 | 8 | 524.00 | 65.50 | 100.0% | 13.4 |
| 0-0.5 | 6 | 245.10 | 40.85 | 100.0% | 19.0 |
| 0.5-1 | 3 | 216.90 | 72.30 | 100.0% | 8.8 |

## By ES Structure VWAP Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 38 | 2665.70 | 70.15 | 100.0% | 13.9 |
| >=24 | 33 | 1167.90 | 35.39 | 100.0% | 2.8 |
| 8-12 | 12 | 1511.90 | 125.99 | 100.0% | 12.0 |
| 12-16 | 7 | 360.60 | 51.51 | 100.0% | 12.3 |
| 2-4 | 7 | 532.30 | 76.04 | 100.0% | 6.5 |
| 16-24 | 6 | 662.30 | 110.38 | 100.0% | 10.7 |
| 0-2 | 3 | 140.90 | 46.97 | 100.0% | 12.0 |

## By Setup Quality Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 50-60 | 32 | 2250.70 | 70.33 | 100.0% | 9.0 |
| 70-80 | 24 | 1634.60 | 68.11 | 100.0% | 12.2 |
| 60-70 | 21 | 1334.40 | 63.54 | 100.0% | 9.9 |
| 40-50 | 17 | 1251.40 | 73.61 | 100.0% | 12.7 |
| 80-90 | 12 | 570.50 | 47.54 | 100.0% | 15.8 |

## By Entry-Veto Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 3-4 | 26 | 1640.00 | 63.08 | 100.0% | 11.9 |
| 1-2 | 25 | 1641.80 | 65.67 | 100.0% | 12.0 |
| 2-3 | 21 | 943.80 | 44.94 | 100.0% | 15.6 |
| 5-6 | 14 | 797.90 | 56.99 | 100.0% | 7.2 |
| 4-5 | 11 | 1278.20 | 116.20 | 100.0% | 9.4 |
| <1 | 9 | 739.90 | 82.21 | 100.0% | 12.0 |

## By Slow-Risk Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <1 | 106 | 7041.60 | 66.43 | 100.0% | 12.0 |

## By Entry Risk Tier

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| standard | 106 | 7041.60 | 66.43 | 100.0% | 12.0 |

## By ES Reclaim Current Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 38 | 2665.70 | 70.15 | 100.0% | 13.9 |
| >=24 | 33 | 1167.90 | 35.39 | 100.0% | 2.8 |
| 8-12 | 12 | 1511.90 | 125.99 | 100.0% | 12.0 |
| 12-16 | 7 | 360.60 | 51.51 | 100.0% | 12.3 |
| 2-4 | 7 | 532.30 | 76.04 | 100.0% | 6.5 |
| 16-24 | 6 | 662.30 | 110.38 | 100.0% | 10.7 |
| 0-2 | 3 | 140.90 | 46.97 | 100.0% | 12.0 |

## By SPX EMA20 Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 72 | 4297.60 | 59.69 | 100.0% | 8.5 |
| 2-4 | 10 | 1077.10 | 107.71 | 100.0% | 19.9 |
| 4-6 | 10 | 665.20 | 66.52 | 100.0% | 12.1 |
| >=12 | 5 | 230.80 | 46.16 | 100.0% | 16.6 |
| 1-2 | 4 | 142.00 | 35.50 | 100.0% | 54.7 |
| 8-12 | 4 | 537.90 | 134.48 | 100.0% | 13.4 |
| 0-1 | 1 | 91.00 | 91.00 | 100.0% | 12.0 |

## By Hold-Time Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 5-15 | 36 | 3273.20 | 90.92 | 100.0% | 9.8 |
| <5 | 30 | 2051.70 | 68.39 | 100.0% | 1.2 |
| 15-30 | 27 | 862.70 | 31.95 | 100.0% | 19.1 |
| 60-180 | 7 | 264.00 | 37.71 | 100.0% | 90.2 |
| 30-60 | 4 | 105.00 | 26.25 | 100.0% | 34.6 |
| 180-720 | 2 | 485.00 | 242.50 | 100.0% | 193.1 |

## By VIX Regime

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| disabled | 106 | 7041.60 | 66.43 | 100.0% | 12.0 |

## By Option Data State

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 80 | 5366.40 | 67.08 | 100.0% | 9.6 |
| VALID_1DTE_ONLY | 20 | 1305.00 | 65.25 | 100.0% | 14.1 |
| STALE_0DTE | 5 | 162.80 | 32.56 | 100.0% | 23.3 |
| EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 |

## By Active Profile Set

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 80 | 5366.40 | 67.08 | 100.0% | 9.6 |
| VALID_1DTE_ONLY | 20 | 1305.00 | 65.25 | 100.0% | 14.1 |
| STALE_0DTE | 5 | 162.80 | 32.56 | 100.0% | 23.3 |
| EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 |

## Monthly Summary

| Month | Trades | PnL | Avg PnL | Median Hold Min | Exposure Hours | PnL/Exposure Hour | Slow >=12h |
| --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| 2026-06 | 72 | 4474.10 | 62.14 | 9.1 | 16.8 | 265.54 | 0 |
| 2026-07 | 34 | 2567.50 | 75.51 | 14.2 | 20.0 | 128.39 | 0 |

## TP Target Distribution

| Target | Trades | PnL | Avg PnL | Median Hold Min |
| --- | ---: | ---: | ---: | ---: |
| 2.40 | 37 | 1356.70 | 36.67 | 4.8 |
| 2.49 | 1 | 45.50 | 45.50 | 20.6 |
| 2.57 | 1 | 93.60 | 93.60 | 5.3 |
| 2.63 | 1 | 39.60 | 39.60 | 12.0 |
| 2.99 | 1 | 105.00 | 105.00 | 8.5 |
| 3.00 | 20 | 1305.00 | 65.25 | 14.1 |
| 3.02 | 2 | 147.60 | 73.80 | 49.9 |
| 3.09 | 1 | 55.80 | 55.80 | 11.9 |
| 3.14 | 1 | 108.50 | 108.50 | 6.5 |
| 3.19 | 1 | 35.00 | 35.00 | 26.0 |
| 3.22 | 1 | 118.80 | 118.80 | 6.6 |
| 3.26 | 1 | 118.80 | 118.80 | 3.8 |
| 3.30 | 1 | 118.80 | 118.80 | 0.1 |
| 3.31 | 2 | 69.00 | 34.50 | 17.2 |
| 3.33 | 1 | 36.00 | 36.00 | 29.9 |
| 3.34 | 1 | 36.00 | 36.00 | 155.4 |
| 3.35 | 1 | 119.00 | 119.00 | 8.4 |
| 3.43 | 1 | 46.80 | 46.80 | 12.7 |
| 3.44 | 1 | 119.00 | 119.00 | 7.3 |
| 3.46 | 1 | 136.50 | 136.50 | 8.8 |
| 3.48 | 1 | 122.50 | 122.50 | 5.8 |
| 3.51 | 1 | 35.00 | 35.00 | 17.4 |
| 3.56 | 1 | 36.00 | 36.00 | 15.6 |
| 3.58 | 1 | 36.00 | 36.00 | 23.6 |
| 3.60 | 8 | 706.10 | 88.26 | 9.5 |
| 4.00 | 2 | 36.00 | 18.00 | 27.2 |
| 6.00 | 3 | 278.40 | 92.80 | 23.3 |
| 12.00 | 7 | 1120.60 | 160.09 | 15.2 |
| 14.06 | 1 | 34.00 | 34.00 | 12.1 |
| 28.66 | 1 | 91.00 | 91.00 | 12.0 |
| 38.75 | 1 | 34.00 | 34.00 | 17.3 |
| 48.31 | 1 | 38.50 | 38.50 | 12.3 |
| 55.78 | 1 | 262.50 | 262.50 | 12.0 |

## Slow Trade Fingerprint
- Trades held >= 12 hours: 0 (0.0%)

## Interpretation Notes
- This strategy exits with take-profit orders only, so a high win rate can hide capital being tied up for a long time.
- The best setting candidates are usually found by reducing slow-to-profit entries, not simply maximizing raw entry count.
- Focus first on buckets with low average PnL or long median hold time, then test stricter RSI/ADX/VWAP/VIX filters against those buckets.
