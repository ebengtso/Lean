# SPX500 IB Trend Scalper Analysis

- Metrics file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_019/execution-metrics.csv`
- Backtest file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_019/launcher/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm.json`
- Completed paired trades: 105
- Entry signals: 105
- Approx open/unpaired entry signals: 0
- Position/order maintenance waits: 8567
- Total paired trade PnL: 6987.60
- Win rate: 100.0%
- Realized loss trades: 0
- Median hold: 12.0 minutes
- Average hold: 21.1 minutes

## Lean Runtime Statistics
- Equity: $106,987.60
- Net Profit: $6,987.60
- Return: 6.99 %
- Probabilistic Sharpe Ratio: 100.000%
- Volume: $44,762,346.20

## Risk And Efficiency
- Exposure hours: 37.0
- PnL per exposure hour: 189.10
- Calendar span days: 12.3
- PnL per calendar day: 567.29
- Trades per calendar day: 8.52
- Exposure share of calendar time: 12.5%
- Growth quality score: 10933.6
- VIX stale at entry: 0.0%
- ES stale rows: 9.4%
- Waiting ES VWAP rows: 0.0%
- Trade-health exit signals: 0
- Trade-health tighten signals: 0
- Slow trades held >= 12 hours: 0 (0.0%)
- Slow exposure hours: 0.0
- Slow PnL per exposure hour: 
- Fast <15m trades: 65
- Fast PnL per exposure hour: 776.68

## Pullback Broken Structure Veto
- Blocked signal rows: 1214
- Blocked by profile: `{"charm_pin_pullback_long": 1162, "pullback_long": 52}`
- Blocked net profit / worst MAE: not available for hard-blocked signals because they do not become completed trades.
- Remaining trades by profile: `{"breakout_long_1dte": 20, "breakout_long_no_0dte": 3, "call_wall_acceptance_long": 1, "charm_pin_pullback_long": 36, "charm_wall_breakaway_long": 7, "pullback_long": 30, "pullback_long_no_0dte": 3, "squeeze_long": 5}`
- Remaining PnL by profile: `{"breakout_long_1dte": 1303.999999999991, "breakout_long_no_0dte": 278.40000000001237, "call_wall_acceptance_long": 91.0, "charm_pin_pullback_long": 1324.400000000136, "charm_wall_breakaway_long": 1120.6000000000058, "pullback_long": 2299.7000000002126, "pullback_long_no_0dte": 91.79999999999018, "squeeze_long": 477.69999999997526}`

## Lean Portfolio And Trade Statistics
- Portfolio: sharpeRatio=30.0414, sortinoRatio=0, alpha=0, beta=0, informationRatio=30.6112, drawdown=0.005
- Trades: sharpeRatio=1.0000, averageMAE=-102.7190, averageMFE=84.0576, largestMAE=-638.75, largestMFE=462.60, maximumIntraTradeDrawdown=-682.50

## Strategy Profile Performance

| Strategy | Enabled | Data State | Profile Set | Trades | PnL | Avg PnL | Win Rate | Median Hold Min | Exposure Hrs | PnL/Exposure Hr | Slow >=12h | Worst MAE | Median MFE | Median TP |
| --- | --- | --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| pullback_long | true | VALID_0DTE | VALID_0DTE | 30 | 2299.70 | 76.66 | 100.0% | 12.0 | 12.4 | 184.74 | 0 | -638.75 | 102.10 | 3.35 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 36 | 1324.40 | 36.79 | 100.0% | 5.0 | 7.7 | 172.32 | 0 | -527.00 | 42.50 | 2.40 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 20 | 1304.00 | 65.20 | 100.0% | 14.1 | 7.7 | 168.63 | 0 | -375.70 | 79.88 | 3.00 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 7 | 1120.60 | 160.09 | 100.0% | 15.2 | 4.7 | 240.49 | 0 | -346.80 | 107.10 | 12.00 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 5 | 477.70 | 95.54 | 100.0% | 12.1 | 1.1 | 424.94 | 0 | -113.90 | 66.30 | 38.75 |
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
| pullback_long | true | VALID_0DTE | VALID_0DTE | 30 | 50.02 | 6.71 | 48.61 | 21.20 | 24.9 | 0 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 36 | 66.83 | 29.59 | 50.60 | 20.43 | 12.8 | 0 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 20 | 66.60 | 5.83 | 70.56 | 26.99 | 23.2 | 0 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 7 | 75.96 | 14.42 | 69.38 | 19.86 | 39.9 | 0 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 5 | 69.68 | 13.69 | 67.57 | 21.29 | 13.5 | 0 |
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
- MAE: average -103.71, median -69.53, worst -638.75
- MFE: average 84.06, median 55.80, best 462.60
- Average MFE / absolute MAE: 0.81

## Intratrade Path
- Trades with path stats: 105; with intratrade price samples: 105
- Went positive before max adverse: 48.6%
- MFE happened before MAE: 8.6%
- TP touched before MAE: 1.0%
- Median MFE available before MAE: 0.00 points
- Median first TP touch: 3.8 minutes
- Median first +1.5 points: 2.9 minutes
- First 15m MFE/MAE medians: 2.40 / -1.95 points

## Worst Tail Trade Autopsy
- Worst tail entry: `2026-07-01T06:48:37+00:00` -> `2026-07-01T09:56:31+00:00`.
- Strategy/profile: `pullback_long` / `pullback_long`. PnL 35.00, MAE -638.75, MFE 43.75, hold 187.9 minutes.
- Profile context: `pullback_long` produced 30 trades, PnL 2299.70, 0 slow >=12h trades, and 32.9% of total PnL.
- Entry state: setup=58.84, ES-VWAP=7.84, VWAP slope=0.0164, VWAP acceleration=-0.0021, RSI=55.24, ADX=29.83, structure score=3.00, higher-low=-2.00, higher-high=-1.25, pullback-from-high=1.25, rolling-high distance=3.75.
- Guard state: setup allowed=`True`, entry veto allowed=`True`, veto points=3.00, slow-risk points=0.00.
- Existing warning reason: ES structure score 3 <= 3; ES structure higher-low -2.00 < 0.25; ES structure higher-high -1.25 < 0.00.
- Strategy selection reason: VALID_0DTE ordered router; ordered ES pullback: trendPrice=7535.00, ema=7535.18, distance=7.84, adx=29.83, rsi=55.24, structure=3.
- Intratrade path: path MFE 1.25, path MAE -17.75, MFE before MAE=`False`, TP reached=`False`.
- Surgical setup floor check: `setup_quality_score >= 58.9` would block this trade, keep 58 trades, retain 52.1% PnL, and leave worst MAE -527.00. It would block 47 trades total.
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
| `long_strategy != "breakout_long_1dte"` | 20 | 6 | 14 | 85 | 5683.60 | 1304.00 | 81.3% | -638.75 | 15409.1 |
| `strategy_profile != "breakout_long_1dte"` | 20 | 6 | 14 | 85 | 5683.60 | 1304.00 | 81.3% | -638.75 | 15409.1 |
| `es_structure_shallow_pullback != "False"` | 20 | 4 | 11 | 90 | 5973.40 | 1014.20 | 85.5% | -638.75 | 15344.9 |
| `es_structure_rising_vwap != "False"` | 20 | 5 | 12 | 88 | 5617.30 | 1370.30 | 80.4% | -638.75 | 15337.4 |
| `long_strategy != "charm_pin_pullback_long"` | 20 | 4 | 32 | 69 | 5663.20 | 1324.40 | 81.0% | -638.75 | 15171.7 |
| `strategy_profile != "charm_pin_pullback_long"` | 20 | 4 | 32 | 69 | 5663.20 | 1324.40 | 81.0% | -638.75 | 15171.7 |
| `path_half_tp_touch_minutes >= 0.183333` | 20 | 12 | 22 | 71 | 5281.50 | 1706.10 | 75.6% | -527.00 | 499.9 |
| `es_reclaim_samples <= 586` | 20 | 5 | 10 | 90 | 5766.80 | 1220.80 | 82.5% | -638.75 | 115.3 |
| `path_first_observed_points >= -0.55` | 20 | 4 | 11 | 90 | 6046.50 | 941.10 | 86.5% | -638.75 | 94.1 |
| `path_first_nonzero_move_points >= -0.55` | 20 | 4 | 11 | 90 | 6046.50 | 941.10 | 86.5% | -638.75 | 94.1 |
| `es_vwap_acceleration >= -0.00146389` | 20 | 6 | 24 | 75 | 5327.20 | 1660.40 | 76.2% | -403.20 | 85.1 |
| `es_vwap_acceleration >= -0.00175328` | 20 | 5 | 22 | 78 | 5592.60 | 1395.00 | 80.0% | -403.20 | 65.9 |

## Upside TP Extension Candidates
| all | No upside TP extension candidates found. |  |  |  |  |  |  |  |  |  |  |

## Event Counts
- blocked: 35712
- position_wait: 8567
- stale_es_vwap: 4867
- trade_risk_extend_signal: 1192
- trade_risk_tighten_signal: 551
- order_event: 473
- waiting_spx_quote: 415
- entry_signal: 105

## Blocked Gate Counts
- setup_quality_allowed: 14367 (disabled=14367)
- above_vwap_confirmed: 8908 (disabled=8908)
- above_vwap: 7989 (disabled=7989)
- es_structure_allowed: 7713 (disabled=7713)
- pullback: 6707 (disabled=6707)
- momentum: 4115 (disabled=4115)
- es_vwap_max_distance_allowed: 3876 (disabled=3876)
- es_vwap_slope_allowed: 3675 (disabled=3675)
- trend_strength: 3298 (disabled=3298)
- es_vwap_acceleration_allowed: 1751 (disabled=1751)
- es_rolling_high_allowed: 483 (disabled=483)
- indicator_slope_allowed: 168 (disabled=168)

## By UTC Hour

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 13 | 14 | 813.60 | 58.11 | 100.0% | 0.4 |
| 14 | 10 | 851.90 | 85.19 | 100.0% | 2.1 |
| 12 | 8 | 353.30 | 44.16 | 100.0% | 12.1 |
| 8 | 8 | 1149.70 | 143.71 | 100.0% | 14.3 |
| 1 | 6 | 512.20 | 85.37 | 100.0% | 3.0 |
| 15 | 6 | 368.10 | 61.35 | 100.0% | 9.2 |
| 18 | 6 | 337.60 | 56.27 | 100.0% | 10.4 |
| 9 | 6 | 324.80 | 54.13 | 100.0% | 14.0 |
| 11 | 5 | 183.30 | 36.66 | 100.0% | 12.8 |
| 19 | 5 | 252.40 | 50.48 | 100.0% | 17.0 |
| 5 | 5 | 245.10 | 49.02 | 100.0% | 20.6 |
| 6 | 5 | 232.60 | 46.52 | 100.0% | 16.4 |
| 2 | 4 | 211.40 | 52.85 | 100.0% | 48.6 |
| 22 | 4 | 392.90 | 98.23 | 100.0% | 14.9 |
| 0 | 3 | 174.40 | 58.13 | 100.0% | 12.1 |
| 7 | 3 | 189.40 | 63.13 | 100.0% | 12.1 |
| 10 | 2 | 55.40 | 27.70 | 100.0% | 18.4 |
| 23 | 2 | 70.00 | 35.00 | 100.0% | 29.5 |
| 3 | 2 | 150.50 | 75.25 | 100.0% | 15.9 |
| 17 | 1 | 119.00 | 119.00 | 100.0% | 7.3 |

## By RSI Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <55 | 56 | 3311.90 | 59.14 | 100.0% | 7.2 |
| 55-60 | 18 | 1352.30 | 75.13 | 100.0% | 15.6 |
| >=75 | 11 | 1009.50 | 91.77 | 100.0% | 9.9 |
| 60-65 | 7 | 351.70 | 50.24 | 100.0% | 8.4 |
| 70-75 | 7 | 377.00 | 53.86 | 100.0% | 17.3 |
| 65-70 | 6 | 585.20 | 97.53 | 100.0% | 15.8 |

## By ADX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <20 | 41 | 2769.60 | 67.55 | 100.0% | 8.4 |
| 20-25 | 22 | 1667.00 | 75.77 | 100.0% | 11.0 |
| 25-30 | 19 | 1140.00 | 60.00 | 100.0% | 12.1 |
| 30-40 | 17 | 1069.60 | 62.92 | 100.0% | 12.0 |
| 40-50 | 5 | 301.80 | 60.36 | 100.0% | 12.0 |
| >=50 | 1 | 39.60 | 39.60 | 100.0% | 17.0 |

## By VIX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| missing | 105 | 6987.60 | 66.55 | 100.0% | 12.0 |

## By ES VWAP Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.25 | 101 | 6406.10 | 63.43 | 100.0% | 12.0 |
| 0.25-0.5 | 3 | 564.50 | 188.17 | 100.0% | 9.4 |
| 0.5-1 | 1 | 17.00 | 17.00 | 100.0% | 29.9 |

## By ES VWAP Acceleration Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.05 | 49 | 3141.10 | 64.10 | 100.0% | 12.1 |
| -0.05-0 | 39 | 2451.90 | 62.87 | 100.0% | 7.3 |
| 0.1-0.25 | 9 | 1001.70 | 111.30 | 100.0% | 14.7 |
| 0.05-0.1 | 5 | 252.40 | 50.48 | 100.0% | 17.3 |
| >=0.25 | 2 | 53.00 | 26.50 | 100.0% | 55.9 |
| -0.25--0.1 | 1 | 87.50 | 87.50 | 100.0% | 6.7 |

## By ES Rolling High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-6 | 26 | 1344.20 | 51.70 | 100.0% | 2.3 |
| 2-4 | 25 | 1315.70 | 52.63 | 100.0% | 12.8 |
| 0-1 | 19 | 1597.70 | 84.09 | 100.0% | 13.2 |
| 6-8 | 15 | 1449.20 | 96.61 | 100.0% | 12.1 |
| 8-12 | 8 | 397.00 | 49.62 | 100.0% | 13.0 |
| 1-2 | 6 | 400.20 | 66.70 | 100.0% | 18.6 |
| 12-20 | 5 | 448.60 | 89.72 | 100.0% | 6.6 |
| >=20 | 1 | 35.00 | 35.00 | 100.0% | 19.1 |

## By ES Rolling High Minutes Since

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 20-30 | 33 | 2395.00 | 72.58 | 100.0% | 7.3 |
| <1 | 24 | 1831.90 | 76.33 | 100.0% | 14.9 |
| 1-3 | 12 | 900.10 | 75.01 | 100.0% | 14.7 |
| 10-20 | 12 | 654.50 | 54.54 | 100.0% | 12.7 |
| 5-10 | 12 | 664.30 | 55.36 | 100.0% | 8.6 |
| 3-5 | 11 | 475.30 | 43.21 | 100.0% | 11.9 |
| 30-60 | 1 | 66.50 | 66.50 | 100.0% | 12.0 |

## By RSI Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| >=3 | 32 | 2489.20 | 77.79 | 100.0% | 12.4 |
| 0-1 | 20 | 973.30 | 48.67 | 100.0% | 11.3 |
| -3--2 | 11 | 430.90 | 39.17 | 100.0% | 5.1 |
| <-3 | 9 | 418.70 | 46.52 | 100.0% | 6.7 |
| -2--1 | 8 | 496.10 | 62.01 | 100.0% | 18.7 |
| 1-2 | 7 | 496.20 | 70.89 | 100.0% | 15.0 |
| -1-0 | 6 | 539.20 | 89.87 | 100.0% | 5.8 |
| 2-3 | 6 | 702.60 | 117.10 | 100.0% | 17.8 |
| missing | 6 | 441.40 | 73.57 | 100.0% | 8.4 |

## By ADX Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-1 | 39 | 2596.00 | 66.56 | 100.0% | 11.9 |
| -1-0 | 34 | 2481.00 | 72.97 | 100.0% | 12.7 |
| 1-2 | 19 | 1231.70 | 64.83 | 100.0% | 7.3 |
| -2--1 | 7 | 237.50 | 33.93 | 100.0% | 33.9 |
| missing | 6 | 441.40 | 73.57 | 100.0% | 8.4 |

## By ES Higher-Low Distance Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 2-4 | 32 | 1580.60 | 49.39 | 100.0% | 15.9 |
| 4-8 | 22 | 2308.20 | 104.92 | 100.0% | 12.0 |
| 1-2 | 21 | 1197.60 | 57.03 | 100.0% | 5.1 |
| >=8 | 13 | 1006.00 | 77.38 | 100.0% | 14.0 |
| 0-0.5 | 10 | 474.90 | 47.49 | 100.0% | 4.5 |
| 0.5-1 | 7 | 420.30 | 60.04 | 100.0% | 11.9 |

## By ES Structure Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4 | 39 | 2513.70 | 64.45 | 100.0% | 12.8 |
| 3 | 33 | 2577.10 | 78.09 | 100.0% | 12.0 |
| 5 | 32 | 1862.80 | 58.21 | 100.0% | 10.3 |
| 2 | 1 | 34.00 | 34.00 | 100.0% | 12.1 |

## By ES Structure Pullback From High

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-2 | 45 | 3583.20 | 79.63 | 100.0% | 13.2 |
| 2-4 | 29 | 1638.20 | 56.49 | 100.0% | 11.9 |
| 4-8 | 26 | 1542.70 | 59.33 | 100.0% | 8.5 |
| 8-12 | 5 | 223.50 | 44.70 | 100.0% | 17.3 |

## By ES Structure Higher-Low Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 38 | 2707.20 | 71.24 | 100.0% | 12.4 |
| 2-4 | 18 | 657.30 | 36.52 | 100.0% | 14.5 |
| 4-8 | 13 | 645.00 | 49.62 | 100.0% | 9.9 |
| 0.5-1 | 11 | 969.20 | 88.11 | 100.0% | 3.8 |
| 1-2 | 10 | 832.20 | 83.22 | 100.0% | 12.5 |
| >=8 | 8 | 682.50 | 85.31 | 100.0% | 12.0 |
| 0-0.5 | 7 | 494.20 | 70.60 | 100.0% | 12.0 |

## By ES Structure Higher-High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 38 | 2678.20 | 70.48 | 100.0% | 8.6 |
| 2-4 | 19 | 1316.20 | 69.27 | 100.0% | 9.4 |
| 4-8 | 16 | 1113.40 | 69.59 | 100.0% | 12.1 |
| 1-2 | 15 | 893.80 | 59.59 | 100.0% | 12.0 |
| >=8 | 8 | 524.00 | 65.50 | 100.0% | 13.4 |
| 0-0.5 | 6 | 245.10 | 40.85 | 100.0% | 19.0 |
| 0.5-1 | 3 | 216.90 | 72.30 | 100.0% | 8.8 |

## By ES Structure VWAP Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 38 | 2665.70 | 70.15 | 100.0% | 13.9 |
| >=24 | 32 | 1135.60 | 35.49 | 100.0% | 2.9 |
| 8-12 | 11 | 1382.50 | 125.68 | 100.0% | 12.1 |
| 12-16 | 8 | 469.30 | 58.66 | 100.0% | 13.0 |
| 2-4 | 7 | 531.30 | 75.90 | 100.0% | 6.5 |
| 16-24 | 6 | 662.30 | 110.38 | 100.0% | 10.7 |
| 0-2 | 3 | 140.90 | 46.97 | 100.0% | 12.0 |

## By Setup Quality Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 50-60 | 33 | 2290.50 | 69.41 | 100.0% | 8.4 |
| 70-80 | 23 | 1604.60 | 69.77 | 100.0% | 12.1 |
| 60-70 | 20 | 1202.80 | 60.14 | 100.0% | 11.9 |
| 40-50 | 17 | 1247.80 | 73.40 | 100.0% | 12.7 |
| 80-90 | 12 | 641.90 | 53.49 | 100.0% | 15.8 |

## By Entry-Veto Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 1-2 | 24 | 1696.20 | 70.68 | 100.0% | 12.0 |
| 3-4 | 24 | 1468.20 | 61.18 | 100.0% | 11.9 |
| 2-3 | 21 | 927.50 | 44.17 | 100.0% | 15.6 |
| 5-6 | 14 | 794.30 | 56.74 | 100.0% | 7.2 |
| 4-5 | 13 | 1361.50 | 104.73 | 100.0% | 9.4 |
| <1 | 9 | 739.90 | 82.21 | 100.0% | 12.0 |

## By Slow-Risk Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <1 | 105 | 6987.60 | 66.55 | 100.0% | 12.0 |

## By Entry Risk Tier

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| standard | 105 | 6987.60 | 66.55 | 100.0% | 12.0 |

## By ES Reclaim Current Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 38 | 2665.70 | 70.15 | 100.0% | 13.9 |
| >=24 | 32 | 1135.60 | 35.49 | 100.0% | 2.9 |
| 8-12 | 11 | 1382.50 | 125.68 | 100.0% | 12.1 |
| 12-16 | 8 | 469.30 | 58.66 | 100.0% | 13.0 |
| 2-4 | 7 | 531.30 | 75.90 | 100.0% | 6.5 |
| 16-24 | 6 | 662.30 | 110.38 | 100.0% | 10.7 |
| 0-2 | 3 | 140.90 | 46.97 | 100.0% | 12.0 |

## By SPX EMA20 Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 70 | 4135.90 | 59.08 | 100.0% | 8.6 |
| 2-4 | 11 | 1111.10 | 101.01 | 100.0% | 15.0 |
| 4-6 | 9 | 626.70 | 69.63 | 100.0% | 12.0 |
| 8-12 | 5 | 650.10 | 130.02 | 100.0% | 12.1 |
| >=12 | 5 | 230.80 | 46.16 | 100.0% | 16.6 |
| 1-2 | 4 | 142.00 | 35.50 | 100.0% | 54.7 |
| 0-1 | 1 | 91.00 | 91.00 | 100.0% | 12.0 |

## By Hold-Time Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 5-15 | 37 | 3390.40 | 91.63 | 100.0% | 9.9 |
| <5 | 28 | 1881.50 | 67.20 | 100.0% | 1.0 |
| 15-30 | 27 | 861.70 | 31.91 | 100.0% | 19.1 |
| 60-180 | 7 | 264.00 | 37.71 | 100.0% | 90.2 |
| 30-60 | 4 | 105.00 | 26.25 | 100.0% | 34.6 |
| 180-720 | 2 | 485.00 | 242.50 | 100.0% | 193.1 |

## By VIX Regime

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| disabled | 105 | 6987.60 | 66.55 | 100.0% | 12.0 |

## By Option Data State

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 79 | 5313.40 | 67.26 | 100.0% | 11.9 |
| VALID_1DTE_ONLY | 20 | 1304.00 | 65.20 | 100.0% | 14.1 |
| STALE_0DTE | 5 | 162.80 | 32.56 | 100.0% | 23.3 |
| EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 |

## By Active Profile Set

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 79 | 5313.40 | 67.26 | 100.0% | 11.9 |
| VALID_1DTE_ONLY | 20 | 1304.00 | 65.20 | 100.0% | 14.1 |
| STALE_0DTE | 5 | 162.80 | 32.56 | 100.0% | 23.3 |
| EXPIRED_0DTE | 1 | 207.40 | 207.40 | 100.0% | 14.7 |

## Monthly Summary

| Month | Trades | PnL | Avg PnL | Median Hold Min | Exposure Hours | PnL/Exposure Hour | Slow >=12h |
| --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| 2026-06 | 71 | 4424.70 | 62.32 | 9.9 | 17.0 | 260.97 | 0 |
| 2026-07 | 34 | 2562.90 | 75.38 | 14.2 | 20.0 | 128.16 | 0 |

## TP Target Distribution

| Target | Trades | PnL | Avg PnL | Median Hold Min |
| --- | ---: | ---: | ---: | ---: |
| 2.40 | 36 | 1324.40 | 36.79 | 5.0 |
| 2.49 | 1 | 45.50 | 45.50 | 20.6 |
| 2.57 | 1 | 93.60 | 93.60 | 5.3 |
| 2.63 | 1 | 39.60 | 39.60 | 12.0 |
| 2.99 | 1 | 105.00 | 105.00 | 8.5 |
| 3.00 | 20 | 1304.00 | 65.20 | 14.1 |
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
| 3.60 | 7 | 576.70 | 82.39 | 12.0 |
| 4.00 | 2 | 36.00 | 18.00 | 27.2 |
| 6.00 | 3 | 278.40 | 92.80 | 23.3 |
| 12.00 | 7 | 1120.60 | 160.09 | 15.2 |
| 14.06 | 1 | 34.00 | 34.00 | 12.1 |
| 28.44 | 1 | 112.20 | 112.20 | 12.0 |
| 28.66 | 1 | 91.00 | 91.00 | 12.0 |
| 38.75 | 1 | 34.00 | 34.00 | 17.3 |
| 48.62 | 1 | 35.00 | 35.00 | 14.0 |
| 55.78 | 1 | 262.50 | 262.50 | 12.0 |

## Slow Trade Fingerprint
- Trades held >= 12 hours: 0 (0.0%)

## Interpretation Notes
- This strategy exits with take-profit orders only, so a high win rate can hide capital being tied up for a long time.
- The best setting candidates are usually found by reducing slow-to-profit entries, not simply maximizing raw entry count.
- Focus first on buckets with low average PnL or long median hold time, then test stricter RSI/ADX/VWAP/VIX filters against those buckets.
