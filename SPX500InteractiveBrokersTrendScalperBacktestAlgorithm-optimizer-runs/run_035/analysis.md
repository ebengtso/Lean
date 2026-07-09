# SPX500 IB Trend Scalper Analysis

- Metrics file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_035/execution-metrics.csv`
- Backtest file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_035/launcher/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm.json`
- Completed paired trades: 107
- Entry signals: 107
- Approx open/unpaired entry signals: 0
- Position/order maintenance waits: 8166
- Total paired trade PnL: 7057.00
- Win rate: 100.0%
- Realized loss trades: 0
- Median hold: 12.0 minutes
- Average hold: 19.8 minutes

## Lean Runtime Statistics
- Equity: $107,057.00
- Net Profit: $7,057.00
- Return: 7.06 %
- Probabilistic Sharpe Ratio: 100.000%
- Volume: $46,101,531.20

## Risk And Efficiency
- Exposure hours: 35.3
- PnL per exposure hour: 200.12
- Calendar span days: 12.3
- PnL per calendar day: 572.92
- Trades per calendar day: 8.69
- Exposure share of calendar time: 11.9%
- Growth quality score: 11092.6
- VIX stale at entry: 0.0%
- ES stale rows: 9.4%
- Waiting ES VWAP rows: 0.0%
- Trade-health exit signals: 0
- Trade-health tighten signals: 0
- Slow trades held >= 12 hours: 0 (0.0%)
- Slow exposure hours: 0.0
- Slow PnL per exposure hour: 
- Fast <15m trades: 66
- Fast PnL per exposure hour: 755.84

## Pullback Broken Structure Veto
- Blocked signal rows: 1244
- Blocked by profile: `{"charm_pin_pullback_long": 1192, "pullback_long": 52}`
- Blocked net profit / worst MAE: not available for hard-blocked signals because they do not become completed trades.
- Remaining trades by profile: `{"breakout_long_1dte": 20, "breakout_long_no_0dte": 2, "call_wall_acceptance_long": 1, "charm_pin_pullback_long": 34, "charm_wall_breakaway_long": 5, "pullback_long": 31, "pullback_long_no_0dte": 4, "squeeze_long": 10}`
- Remaining PnL by profile: `{"breakout_long_1dte": 1300.8999999999905, "breakout_long_no_0dte": 175.40000000001237, "call_wall_acceptance_long": 91.0, "charm_pin_pullback_long": 1261.5000000001082, "charm_wall_breakaway_long": 985.5999999999876, "pullback_long": 2411.800000000194, "pullback_long_no_0dte": 109.79999999999018, "squeeze_long": 721.0000000000064}`

## Lean Portfolio And Trade Statistics
- Portfolio: sharpeRatio=31.2170, sortinoRatio=0, alpha=0, beta=0, informationRatio=31.7984, drawdown=0.004
- Trades: sharpeRatio=1.0156, averageMAE=-97.6776, averageMFE=84.6070, largestMAE=-513.4, largestMFE=462.60, maximumIntraTradeDrawdown=-564.4

## Strategy Profile Performance

| Strategy | Enabled | Data State | Profile Set | Trades | PnL | Avg PnL | Win Rate | Median Hold Min | Exposure Hrs | PnL/Exposure Hr | Slow >=12h | Worst MAE | Median MFE | Median TP |
| --- | --- | --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| pullback_long | true | VALID_0DTE | VALID_0DTE | 31 | 2411.80 | 77.80 | 100.0% | 12.0 | 9.6 | 252.10 | 0 | -403.20 | 98.00 | 3.33 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 20 | 1300.90 | 65.04 | 100.0% | 14.1 | 7.7 | 168.23 | 0 | -375.70 | 79.88 | 3.00 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 34 | 1261.50 | 37.10 | 100.0% | 5.0 | 7.0 | 180.29 | 0 | -513.40 | 42.50 | 2.40 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 5 | 985.60 | 197.12 | 100.0% | 16.0 | 4.2 | 234.36 | 0 | -346.80 | 146.20 | 12.00 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 10 | 721.00 | 72.10 | 100.0% | 15.7 | 3.9 | 187.16 | 0 | -208.25 | 77.78 | 33.59 |
| breakout_long_no_0dte | true | EXPIRED_0DTE | EXPIRED_0DTE | 1 | 139.40 | 139.40 | 100.0% | 14.4 | 0.2 | 578.82 | 0 | -86.70 | 232.90 | 4.00 |
| pullback_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 4 | 109.80 | 27.45 | 100.0% | 27.2 | 2.0 | 54.18 | 0 | -103.50 | 27.90 | 3.74 |
| call_wall_acceptance_long | true | VALID_0DTE | VALID_0DTE | 1 | 91.00 | 91.00 | 100.0% | 12.0 | 0.2 | 455.00 | 0 | -11.70 | 131.30 | 28.66 |
| breakout_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 1 | 36.00 | 36.00 | 100.0% | 26.5 | 0.4 | 81.41 | 0 | -117.00 | 52.20 | 4.00 |
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
| pullback_long | true | VALID_0DTE | VALID_0DTE | 31 | 50.03 | 6.44 | 49.20 | 20.59 | 18.5 | 0 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 20 | 66.60 | 5.83 | 70.56 | 26.99 | 23.2 | 0 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 34 | 66.83 | 29.56 | 49.67 | 19.65 | 12.3 | 0 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 5 | 75.96 | 21.06 | 57.99 | 17.35 | 50.5 | 0 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 10 | 69.16 | 11.21 | 69.11 | 21.34 | 23.1 | 0 |
| breakout_long_no_0dte | true | EXPIRED_0DTE | EXPIRED_0DTE | 1 | 71.04 | 7.54 | 81.57 | 27.17 | 14.4 | 0 |
| pullback_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 4 | 54.85 | 4.10 | 49.59 | 18.94 | 30.4 | 0 |
| call_wall_acceptance_long | true | VALID_0DTE | VALID_0DTE | 1 | 72.50 | 16.99 | 53.58 | 42.75 | 12.0 | 0 |
| breakout_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 1 | 67.20 | 5.05 | 61.87 | 31.04 | 26.5 | 0 |
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
- MAE: average -98.60, median -69.53, worst -513.40
- MFE: average 84.61, median 56.10, best 462.60
- Average MFE / absolute MAE: 0.86

## Intratrade Path
- Trades with path stats: 107; with intratrade price samples: 107
- Went positive before max adverse: 53.3%
- MFE happened before MAE: 9.3%
- TP touched before MAE: 0.9%
- Median MFE available before MAE: 0.05 points
- Median first TP touch: 3.4 minutes
- Median first +1.5 points: 3.0 minutes
- First 15m MFE/MAE medians: 2.40 / -1.90 points

## Worst Tail Trade Autopsy
- Worst tail entry: `2026-06-26T12:36:24+00:00` -> `2026-06-26T13:56:26+00:00`.
- Strategy/profile: `charm_pin_pullback_long` / `charm_pin_pullback_long`. PnL 42.50, MAE -513.40, MFE 51.00, hold 80.0 minutes.
- Profile context: `charm_pin_pullback_long` produced 34 trades, PnL 1261.50, 0 slow >=12h trades, and 17.9% of total PnL.
- Entry state: setup=61.77, ES-VWAP=26.69, VWAP slope=0.0417, VWAP acceleration=-0.0179, RSI=42.42, ADX=17.95, structure score=4.00, higher-low=0.2500, higher-high=3.75, pullback-from-high=9.25, rolling-high distance=14.25.
- Guard state: setup allowed=`True`, entry veto allowed=`True`, veto points=4.00, slow-risk points=0.00.
- Existing warning reason: ES pullback from high 9.25 >= 5.00; RSI slope -3.8597 <= -2.0000; ADX 17.95 <= 18.00; RSI 42.42 <= 45.00.
- Strategy selection reason: positive gamma/charm pin pullback: expectedMovePosition=0.0105, netCharm30m=-25186308, lowerFade=False, pullback=True, dynamicMaxVwapDistance=17.89.
- Intratrade path: path MFE 2.50, path MAE -27.70, MFE before MAE=`False`, TP reached=`True`.
- Surgical setup floor check: `setup_quality_score >= 61.8` would block this trade, keep 52 trades, retain 46.0% PnL, and leave worst MAE -375.70. It would block 55 trades total.
- No single candidate threshold in the report cleanly removes this tail; the closest visible guard is setup quality 61.77.

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
| `long_strategy != "breakout_long_1dte"` | 21 | 6 | 14 | 87 | 5756.10 | 1300.90 | 81.6% | -513.40 | 12382.2 |
| `strategy_profile != "breakout_long_1dte"` | 21 | 6 | 14 | 87 | 5756.10 | 1300.90 | 81.6% | -513.40 | 12382.2 |
| `es_structure_rising_vwap != "False"` | 21 | 6 | 13 | 88 | 5681.40 | 1375.60 | 80.5% | -513.40 | 12372.5 |
| `path_half_tp_touch_minutes >= 0.183333` | 21 | 12 | 24 | 71 | 5294.60 | 1762.40 | 75.0% | -513.40 | 446.8 |
| `es_structure_higher_high_distance <= 3.75` | 21 | 7 | 18 | 82 | 5451.60 | 1605.40 | 77.3% | -513.40 | 150.7 |
| `option_strike_map_target_1_strike >= 7475` | 21 | 5 | 10 | 92 | 6047.70 | 1009.30 | 85.7% | -403.20 | 136.7 |
| `es_structure_higher_low_distance >= -1` | 21 | 6 | 18 | 83 | 5730.90 | 1326.10 | 81.2% | -513.40 | 134.3 |
| `es_structure_pullback_from_high <= 3.25` | 21 | 8 | 28 | 71 | 5066.10 | 1990.90 | 71.8% | -403.20 | 133.0 |
| `es_structure_higher_high_distance <= 3.5` | 21 | 8 | 19 | 80 | 4989.10 | 2067.90 | 70.7% | -403.20 | 132.6 |
| `es_structure_pullback_from_high <= 3.75` | 21 | 7 | 25 | 75 | 5210.60 | 1846.40 | 73.8% | -403.20 | 96.8 |
| `path_first_observed_points <= -0.2` | 21 | 7 | 24 | 76 | 5055.20 | 2001.80 | 71.6% | -403.20 | 70.3 |
| `path_first_nonzero_move_points <= -0.2` | 21 | 7 | 24 | 76 | 5055.20 | 2001.80 | 71.6% | -403.20 | 70.3 |

## Upside TP Extension Candidates
| all | No upside TP extension candidates found. |  |  |  |  |  |  |  |  |  |  |

## Event Counts
- blocked: 36113
- position_wait: 8166
- stale_es_vwap: 4867
- trade_risk_extend_signal: 1192
- trade_risk_tighten_signal: 616
- order_event: 483
- waiting_spx_quote: 415
- entry_signal: 107

## Blocked Gate Counts
- setup_quality_allowed: 14461 (disabled=14461)
- above_vwap_confirmed: 9102 (disabled=9102)
- above_vwap: 8097 (disabled=8097)
- es_structure_allowed: 7855 (disabled=7855)
- pullback: 6609 (disabled=6609)
- momentum: 4248 (disabled=4248)
- es_vwap_max_distance_allowed: 3895 (disabled=3895)
- es_vwap_slope_allowed: 3699 (disabled=3699)
- trend_strength: 3333 (disabled=3333)
- es_vwap_acceleration_allowed: 1909 (disabled=1909)
- es_rolling_high_allowed: 518 (disabled=518)
- indicator_slope_allowed: 155 (disabled=155)

## By UTC Hour

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 13 | 12 | 735.60 | 61.30 | 100.0% | 0.4 |
| 8 | 12 | 1321.70 | 110.14 | 100.0% | 20.1 |
| 14 | 10 | 851.90 | 85.19 | 100.0% | 2.1 |
| 12 | 8 | 353.30 | 44.16 | 100.0% | 12.1 |
| 1 | 6 | 512.20 | 85.37 | 100.0% | 3.0 |
| 15 | 6 | 368.10 | 61.35 | 100.0% | 9.2 |
| 18 | 6 | 337.60 | 56.27 | 100.0% | 10.4 |
| 11 | 5 | 178.20 | 35.64 | 100.0% | 12.0 |
| 19 | 5 | 276.20 | 55.24 | 100.0% | 8.4 |
| 5 | 5 | 245.10 | 49.02 | 100.0% | 20.6 |
| 6 | 5 | 243.10 | 48.62 | 100.0% | 16.4 |
| 9 | 5 | 289.80 | 57.96 | 100.0% | 12.0 |
| 2 | 4 | 210.40 | 52.60 | 100.0% | 48.6 |
| 22 | 4 | 325.90 | 81.48 | 100.0% | 14.7 |
| 7 | 4 | 241.70 | 60.42 | 100.0% | 12.0 |
| 0 | 3 | 174.40 | 58.13 | 100.0% | 12.1 |
| 10 | 2 | 55.40 | 27.70 | 100.0% | 18.4 |
| 23 | 2 | 70.00 | 35.00 | 100.0% | 29.5 |
| 3 | 2 | 147.40 | 73.70 | 100.0% | 15.9 |
| 17 | 1 | 119.00 | 119.00 | 100.0% | 7.3 |

## By RSI Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <55 | 57 | 3395.40 | 59.57 | 100.0% | 7.2 |
| 55-60 | 18 | 1373.70 | 76.32 | 100.0% | 14.7 |
| >=75 | 10 | 905.50 | 90.55 | 100.0% | 7.8 |
| 60-65 | 9 | 428.40 | 47.60 | 100.0% | 26.5 |
| 70-75 | 8 | 411.00 | 51.38 | 100.0% | 18.7 |
| 65-70 | 5 | 543.00 | 108.60 | 100.0% | 16.4 |

## By ADX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <20 | 44 | 2884.30 | 65.55 | 100.0% | 10.3 |
| 20-25 | 21 | 1665.50 | 79.31 | 100.0% | 12.2 |
| 30-40 | 20 | 1199.80 | 59.99 | 100.0% | 12.0 |
| 25-30 | 16 | 966.00 | 60.38 | 100.0% | 12.0 |
| 40-50 | 5 | 301.80 | 60.36 | 100.0% | 12.0 |
| >=50 | 1 | 39.60 | 39.60 | 100.0% | 17.0 |

## By VIX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| missing | 107 | 7057.00 | 65.95 | 100.0% | 12.0 |

## By ES VWAP Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.25 | 103 | 6475.50 | 62.87 | 100.0% | 12.0 |
| 0.25-0.5 | 3 | 564.50 | 188.17 | 100.0% | 9.4 |
| 0.5-1 | 1 | 17.00 | 17.00 | 100.0% | 29.9 |

## By ES VWAP Acceleration Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.05 | 51 | 3301.80 | 64.74 | 100.0% | 12.0 |
| -0.05-0 | 37 | 2374.60 | 64.18 | 100.0% | 7.3 |
| 0.1-0.25 | 9 | 934.70 | 103.86 | 100.0% | 14.4 |
| 0.05-0.1 | 6 | 287.40 | 47.90 | 100.0% | 20.5 |
| >=0.25 | 2 | 53.00 | 26.50 | 100.0% | 28.2 |
| -0.1--0.05 | 1 | 18.00 | 18.00 | 100.0% | 55.4 |
| -0.25--0.1 | 1 | 87.50 | 87.50 | 100.0% | 6.7 |

## By ES Rolling High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-6 | 29 | 1505.90 | 51.93 | 100.0% | 5.8 |
| 2-4 | 22 | 1213.40 | 55.15 | 100.0% | 13.6 |
| 0-1 | 20 | 1564.90 | 78.25 | 100.0% | 13.8 |
| 6-8 | 14 | 1432.20 | 102.30 | 100.0% | 10.8 |
| 8-12 | 10 | 451.00 | 45.10 | 100.0% | 15.7 |
| 12-20 | 6 | 489.40 | 81.57 | 100.0% | 5.2 |
| 1-2 | 5 | 365.20 | 73.04 | 100.0% | 16.5 |
| >=20 | 1 | 35.00 | 35.00 | 100.0% | 19.1 |

## By ES Rolling High Minutes Since

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 20-30 | 36 | 2531.30 | 70.31 | 100.0% | 8.0 |
| <1 | 23 | 1717.60 | 74.68 | 100.0% | 14.4 |
| 1-3 | 13 | 945.60 | 72.74 | 100.0% | 17.3 |
| 10-20 | 12 | 653.00 | 54.42 | 100.0% | 12.3 |
| 5-10 | 12 | 641.50 | 53.46 | 100.0% | 10.3 |
| 3-5 | 10 | 501.50 | 50.15 | 100.0% | 10.2 |
| 30-60 | 1 | 66.50 | 66.50 | 100.0% | 12.0 |

## By RSI Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| >=3 | 33 | 2486.50 | 75.35 | 100.0% | 12.0 |
| 0-1 | 20 | 1019.20 | 50.96 | 100.0% | 6.0 |
| -1-0 | 9 | 609.20 | 67.69 | 100.0% | 12.0 |
| <-3 | 9 | 418.70 | 46.52 | 100.0% | 6.7 |
| -3--2 | 8 | 323.80 | 40.48 | 100.0% | 6.8 |
| 1-2 | 8 | 524.00 | 65.50 | 100.0% | 15.8 |
| -2--1 | 7 | 514.60 | 73.51 | 100.0% | 12.0 |
| missing | 7 | 459.40 | 65.63 | 100.0% | 8.5 |
| 2-3 | 6 | 701.60 | 116.93 | 100.0% | 17.8 |

## By ADX Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-1 | 38 | 2484.10 | 65.37 | 100.0% | 11.9 |
| -1-0 | 34 | 2546.40 | 74.89 | 100.0% | 12.3 |
| 1-2 | 20 | 1266.70 | 63.33 | 100.0% | 7.8 |
| -2--1 | 8 | 300.40 | 37.55 | 100.0% | 21.3 |
| missing | 7 | 459.40 | 65.63 | 100.0% | 8.5 |

## By ES Higher-Low Distance Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 2-4 | 34 | 1759.40 | 51.75 | 100.0% | 13.8 |
| 4-8 | 21 | 2261.90 | 107.71 | 100.0% | 12.0 |
| 1-2 | 20 | 1136.60 | 56.83 | 100.0% | 7.8 |
| >=8 | 15 | 1009.00 | 67.27 | 100.0% | 14.4 |
| 0-0.5 | 10 | 469.80 | 46.98 | 100.0% | 4.5 |
| 0.5-1 | 7 | 420.30 | 60.04 | 100.0% | 11.9 |

## By ES Structure Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4 | 40 | 2483.70 | 62.09 | 100.0% | 12.0 |
| 3 | 35 | 2677.20 | 76.49 | 100.0% | 12.0 |
| 5 | 31 | 1862.10 | 60.07 | 100.0% | 11.9 |
| 2 | 1 | 34.00 | 34.00 | 100.0% | 12.1 |

## By ES Structure Pullback From High

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-2 | 47 | 3615.70 | 76.93 | 100.0% | 12.1 |
| 2-4 | 28 | 1594.90 | 56.96 | 100.0% | 11.9 |
| 4-8 | 25 | 1568.90 | 62.76 | 100.0% | 8.4 |
| 8-12 | 7 | 277.50 | 39.64 | 100.0% | 26.5 |

## By ES Structure Higher-Low Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 38 | 2754.30 | 72.48 | 100.0% | 12.0 |
| 2-4 | 17 | 635.50 | 37.38 | 100.0% | 20.0 |
| 1-2 | 12 | 825.40 | 68.78 | 100.0% | 11.9 |
| 4-8 | 12 | 579.00 | 48.25 | 100.0% | 10.9 |
| 0.5-1 | 11 | 966.10 | 87.83 | 100.0% | 3.8 |
| 0-0.5 | 9 | 614.20 | 68.24 | 100.0% | 12.0 |
| >=8 | 8 | 682.50 | 85.31 | 100.0% | 12.0 |

## By ES Structure Higher-High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 39 | 2742.00 | 70.31 | 100.0% | 8.5 |
| 2-4 | 19 | 1334.20 | 70.22 | 100.0% | 9.4 |
| 4-8 | 17 | 1149.40 | 67.61 | 100.0% | 12.1 |
| 1-2 | 15 | 894.40 | 59.63 | 100.0% | 20.0 |
| >=8 | 8 | 456.00 | 57.00 | 100.0% | 13.3 |
| 0-0.5 | 5 | 228.10 | 45.62 | 100.0% | 17.4 |
| 0.5-1 | 4 | 252.90 | 63.23 | 100.0% | 10.4 |

## By ES Structure VWAP Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 39 | 2629.60 | 67.43 | 100.0% | 14.4 |
| >=24 | 29 | 1031.90 | 35.58 | 100.0% | 2.8 |
| 8-12 | 12 | 1431.60 | 119.30 | 100.0% | 17.8 |
| 2-4 | 9 | 609.80 | 67.76 | 100.0% | 12.0 |
| 12-16 | 7 | 426.10 | 60.87 | 100.0% | 12.0 |
| 16-24 | 7 | 703.10 | 100.44 | 100.0% | 9.4 |
| 0-2 | 4 | 224.90 | 56.22 | 100.0% | 11.9 |

## By Setup Quality Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 50-60 | 34 | 2397.90 | 70.53 | 100.0% | 7.5 |
| 60-70 | 26 | 1406.30 | 54.09 | 100.0% | 12.0 |
| 70-80 | 20 | 1486.30 | 74.32 | 100.0% | 12.0 |
| 40-50 | 17 | 1251.40 | 73.61 | 100.0% | 12.7 |
| 80-90 | 10 | 515.10 | 51.51 | 100.0% | 15.8 |

## By Entry-Veto Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 1-2 | 23 | 1586.40 | 68.97 | 100.0% | 12.0 |
| 2-3 | 23 | 977.40 | 42.50 | 100.0% | 16.0 |
| 3-4 | 23 | 1451.20 | 63.10 | 100.0% | 11.9 |
| 4-5 | 15 | 1505.00 | 100.33 | 100.0% | 9.4 |
| 5-6 | 14 | 797.90 | 56.99 | 100.0% | 7.2 |
| <1 | 9 | 739.10 | 82.12 | 100.0% | 12.0 |

## By Slow-Risk Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <1 | 107 | 7057.00 | 65.95 | 100.0% | 12.0 |

## By Entry Risk Tier

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| standard | 107 | 7057.00 | 65.95 | 100.0% | 12.0 |

## By ES Reclaim Current Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 39 | 2629.60 | 67.43 | 100.0% | 14.4 |
| >=24 | 29 | 1031.90 | 35.58 | 100.0% | 2.8 |
| 8-12 | 12 | 1431.60 | 119.30 | 100.0% | 17.8 |
| 2-4 | 9 | 609.80 | 67.76 | 100.0% | 12.0 |
| 12-16 | 7 | 426.10 | 60.87 | 100.0% | 12.0 |
| 16-24 | 7 | 703.10 | 100.44 | 100.0% | 9.4 |
| 0-2 | 4 | 224.90 | 56.22 | 100.0% | 11.9 |

## By SPX EMA20 Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 70 | 4203.10 | 60.04 | 100.0% | 8.6 |
| 2-4 | 13 | 1190.50 | 91.58 | 100.0% | 24.9 |
| 4-6 | 9 | 618.50 | 68.72 | 100.0% | 12.0 |
| 8-12 | 5 | 582.10 | 116.42 | 100.0% | 12.1 |
| 1-2 | 4 | 142.00 | 35.50 | 100.0% | 54.7 |
| >=12 | 3 | 159.80 | 53.27 | 100.0% | 16.0 |
| 6-8 | 2 | 70.00 | 35.00 | 100.0% | 40.7 |
| 0-1 | 1 | 91.00 | 91.00 | 100.0% | 12.0 |

## By Hold-Time Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 5-15 | 38 | 3376.80 | 88.86 | 100.0% | 10.9 |
| 15-30 | 28 | 890.50 | 31.80 | 100.0% | 19.5 |
| <5 | 28 | 1925.20 | 68.76 | 100.0% | 1.4 |
| 30-60 | 6 | 186.50 | 31.08 | 100.0% | 41.3 |
| 60-180 | 6 | 228.00 | 38.00 | 100.0% | 101.3 |
| 180-720 | 1 | 450.00 | 450.00 | 100.0% | 198.3 |

## By VIX Regime

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| disabled | 107 | 7057.00 | 65.95 | 100.0% | 12.0 |

## By Option Data State

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 81 | 5470.90 | 67.54 | 100.0% | 12.0 |
| VALID_1DTE_ONLY | 20 | 1300.90 | 65.04 | 100.0% | 14.1 |
| STALE_0DTE | 5 | 145.80 | 29.16 | 100.0% | 26.5 |
| EXPIRED_0DTE | 1 | 139.40 | 139.40 | 100.0% | 14.4 |

## By Active Profile Set

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 81 | 5470.90 | 67.54 | 100.0% | 12.0 |
| VALID_1DTE_ONLY | 20 | 1300.90 | 65.04 | 100.0% | 14.1 |
| STALE_0DTE | 5 | 145.80 | 29.16 | 100.0% | 26.5 |
| EXPIRED_0DTE | 1 | 139.40 | 139.40 | 100.0% | 14.4 |

## Monthly Summary

| Month | Trades | PnL | Avg PnL | Median Hold Min | Exposure Hours | PnL/Exposure Hour | Slow >=12h |
| --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| 2026-06 | 68 | 4254.70 | 62.57 | 9.6 | 15.9 | 268.04 | 0 |
| 2026-07 | 39 | 2802.30 | 71.85 | 15.6 | 19.4 | 144.52 | 0 |

## TP Target Distribution

| Target | Trades | PnL | Avg PnL | Median Hold Min |
| --- | ---: | ---: | ---: | ---: |
| 2.34 | 1 | 84.00 | 84.00 | 3.0 |
| 2.40 | 34 | 1261.50 | 37.10 | 5.0 |
| 2.49 | 1 | 45.50 | 45.50 | 20.6 |
| 2.57 | 1 | 93.60 | 93.60 | 5.3 |
| 2.63 | 1 | 39.60 | 39.60 | 12.0 |
| 2.99 | 1 | 105.00 | 105.00 | 8.5 |
| 3.00 | 20 | 1300.90 | 65.04 | 14.1 |
| 3.02 | 2 | 147.60 | 73.80 | 49.9 |
| 3.09 | 1 | 55.80 | 55.80 | 11.9 |
| 3.13 | 1 | 59.50 | 59.50 | 12.0 |
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
| 3.48 | 2 | 140.50 | 70.25 | 30.6 |
| 3.51 | 1 | 35.00 | 35.00 | 17.4 |
| 3.56 | 1 | 36.00 | 36.00 | 15.6 |
| 3.58 | 1 | 36.00 | 36.00 | 23.6 |
| 3.60 | 6 | 545.30 | 90.88 | 9.5 |
| 4.00 | 4 | 211.40 | 52.85 | 21.4 |
| 12.00 | 5 | 985.60 | 197.12 | 16.0 |
| 14.06 | 1 | 34.00 | 34.00 | 12.1 |
| 15.00 | 1 | 45.50 | 45.50 | 44.6 |
| 16.25 | 1 | 35.00 | 35.00 | 23.6 |
| 23.75 | 1 | 35.00 | 35.00 | 57.7 |
| 28.44 | 1 | 112.20 | 112.20 | 12.0 |
| 28.66 | 1 | 91.00 | 91.00 | 12.0 |
| 38.75 | 2 | 125.80 | 62.90 | 14.7 |
| 48.62 | 2 | 71.00 | 35.50 | 19.9 |
| 55.78 | 1 | 262.50 | 262.50 | 12.0 |

## Slow Trade Fingerprint
- Trades held >= 12 hours: 0 (0.0%)

## Interpretation Notes
- This strategy exits with take-profit orders only, so a high win rate can hide capital being tied up for a long time.
- The best setting candidates are usually found by reducing slow-to-profit entries, not simply maximizing raw entry count.
- Focus first on buckets with low average PnL or long median hold time, then test stricter RSI/ADX/VWAP/VIX filters against those buckets.
