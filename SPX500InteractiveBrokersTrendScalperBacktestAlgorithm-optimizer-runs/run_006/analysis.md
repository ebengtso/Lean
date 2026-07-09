# SPX500 IB Trend Scalper Analysis

- Metrics file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_006/execution-metrics.csv`
- Backtest file: `/Users/erikbengtson/Lean2026/LeanCustom/LauncherBacktest/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm-optimizer-runs/run_006/launcher/SPX500InteractiveBrokersTrendScalperBacktestAlgorithm.json`
- Completed paired trades: 105
- Entry signals: 105
- Approx open/unpaired entry signals: 0
- Position/order maintenance waits: 8094
- Total paired trade PnL: 6861.00
- Win rate: 100.0%
- Realized loss trades: 0
- Median hold: 12.0 minutes
- Average hold: 20.0 minutes

## Lean Runtime Statistics
- Equity: $106,861.00
- Net Profit: $6,861.00
- Return: 6.86 %
- Probabilistic Sharpe Ratio: 100.000%
- Volume: $44,997,575.80

## Risk And Efficiency
- Exposure hours: 35.0
- PnL per exposure hour: 196.24
- Calendar span days: 12.3
- PnL per calendar day: 557.01
- Trades per calendar day: 8.52
- Exposure share of calendar time: 11.8%
- Growth quality score: 10884.0
- VIX stale at entry: 0.0%
- ES stale rows: 9.4%
- Waiting ES VWAP rows: 0.0%
- Trade-health exit signals: 0
- Trade-health tighten signals: 0
- Slow trades held >= 12 hours: 0 (0.0%)
- Slow exposure hours: 0.0
- Slow PnL per exposure hour: 
- Fast <15m trades: 64
- Fast PnL per exposure hour: 760.84

## Pullback Broken Structure Veto
- Blocked signal rows: 1226
- Blocked by profile: `{"charm_pin_pullback_long": 1174, "pullback_long": 52}`
- Blocked net profit / worst MAE: not available for hard-blocked signals because they do not become completed trades.
- Remaining trades by profile: `{"breakout_long_1dte": 20, "call_wall_acceptance_long": 1, "charm_pin_pullback_long": 34, "charm_wall_breakaway_long": 5, "pullback_long": 31, "pullback_long_no_0dte": 4, "squeeze_long": 10}`
- Remaining PnL by profile: `{"breakout_long_1dte": 1298.6999999999907, "call_wall_acceptance_long": 91.0, "charm_pin_pullback_long": 1237.7000000001144, "charm_wall_breakaway_long": 985.5999999999876, "pullback_long": 2404.600000000193, "pullback_long_no_0dte": 122.3999999999869, "squeeze_long": 721.0000000000064}`

## Lean Portfolio And Trade Statistics
- Portfolio: sharpeRatio=29.7494, sortinoRatio=0, alpha=0, beta=0, informationRatio=30.3334, drawdown=0.004
- Trades: sharpeRatio=1.0031, averageMAE=-97.8533, averageMFE=83.8719, largestMAE=-527.0, largestMFE=462.60, maximumIntraTradeDrawdown=-569.5

## Strategy Profile Performance

| Strategy | Enabled | Data State | Profile Set | Trades | PnL | Avg PnL | Win Rate | Median Hold Min | Exposure Hrs | PnL/Exposure Hr | Slow >=12h | Worst MAE | Median MFE | Median TP |
| --- | --- | --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| pullback_long | true | VALID_0DTE | VALID_0DTE | 31 | 2404.60 | 77.57 | 100.0% | 12.0 | 9.6 | 251.35 | 0 | -403.20 | 98.00 | 3.33 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 20 | 1298.70 | 64.93 | 100.0% | 14.1 | 7.7 | 167.94 | 0 | -375.70 | 79.88 | 3.00 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 34 | 1237.70 | 36.40 | 100.0% | 5.3 | 7.5 | 164.67 | 0 | -527.00 | 42.50 | 2.40 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 5 | 985.60 | 197.12 | 100.0% | 16.0 | 4.2 | 234.36 | 0 | -346.80 | 146.20 | 12.00 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 10 | 721.00 | 72.10 | 100.0% | 15.7 | 3.9 | 187.16 | 0 | -208.25 | 77.78 | 33.59 |
| pullback_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 4 | 122.40 | 30.60 | 100.0% | 27.2 | 1.9 | 64.79 | 0 | -103.50 | 49.50 | 4.00 |
| call_wall_acceptance_long | true | VALID_0DTE | VALID_0DTE | 1 | 91.00 | 91.00 | 100.0% | 12.0 | 0.2 | 455.00 | 0 | -11.70 | 131.30 | 28.66 |
| breakout_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| wall_reclaim_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| wall_breakout_retest_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| late_day_pin_fade | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| negative_gamma_momentum_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| trend_day_pullback_long | false | VALID_0DTE | VALID_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| breakout_long_no_0dte | false | MISSING_0DTE | MISSING_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| pullback_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |
| squeeze_long_no_0dte | false | MISSING_0DTE | MISSING_0DTE | 0 | 0.00 |  |  |  | 0.0 |  | 0 |  |  |  |

## Strategy Entry Fingerprints

| Strategy | Enabled | Data State | Profile Set | Trades | Median Setup | Median ES-VWAP | Median RSI | Median ADX | Avg Hold Min | Slow >=12h |
| --- | --- | --- | --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| pullback_long | true | VALID_0DTE | VALID_0DTE | 31 | 50.03 | 6.44 | 49.20 | 20.59 | 18.5 | 0 |
| breakout_long_1dte | true | VALID_1DTE_ONLY | VALID_1DTE_ONLY | 20 | 66.60 | 5.83 | 70.56 | 26.99 | 23.2 | 0 |
| charm_pin_pullback_long | true | VALID_0DTE | VALID_0DTE | 34 | 66.16 | 29.56 | 49.07 | 19.65 | 13.3 | 0 |
| charm_wall_breakaway_long | true | VALID_0DTE | VALID_0DTE | 5 | 75.96 | 21.06 | 57.99 | 17.35 | 50.5 | 0 |
| squeeze_long | true | VALID_0DTE | VALID_0DTE | 10 | 69.16 | 11.21 | 69.11 | 21.34 | 23.1 | 0 |
| pullback_long_no_0dte | true | STALE_0DTE | STALE_0DTE | 4 | 56.70 | 3.38 | 51.98 | 23.08 | 28.3 | 0 |
| call_wall_acceptance_long | true | VALID_0DTE | VALID_0DTE | 1 | 72.50 | 16.99 | 53.58 | 42.75 | 12.0 | 0 |
| breakout_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| wall_reclaim_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| wall_breakout_retest_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| late_day_pin_fade | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| negative_gamma_momentum_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| trend_day_pullback_long | false | VALID_0DTE | VALID_0DTE | 0 |  |  |  |  |  | 0 |
| breakout_long_no_0dte | false | MISSING_0DTE | MISSING_0DTE | 0 |  |  |  |  |  | 0 |
| pullback_long_no_0dte | true | MISSING_0DTE | MISSING_0DTE | 0 |  |  |  |  |  | 0 |
| squeeze_long_no_0dte | false | MISSING_0DTE | MISSING_0DTE | 0 |  |  |  |  |  | 0 |

## MAE And MFE
- MAE: average -98.79, median -64.17, worst -527.00
- MFE: average 83.87, median 61.25, best 462.60
- Average MFE / absolute MAE: 0.85

## Intratrade Path
- Trades with path stats: 105; with intratrade price samples: 105
- Went positive before max adverse: 50.5%
- MFE happened before MAE: 9.5%
- TP touched before MAE: 1.0%
- Median MFE available before MAE: 0.05 points
- Median first TP touch: 3.8 minutes
- Median first +1.5 points: 3.0 minutes
- First 15m MFE/MAE medians: 2.40 / -1.80 points

## Worst Tail Trade Autopsy
- Worst tail entry: `2026-06-26T12:36:10+00:00` -> `2026-06-26T13:56:26+00:00`.
- Strategy/profile: `charm_pin_pullback_long` / `charm_pin_pullback_long`. PnL 42.50, MAE -527.00, MFE 42.50, hold 80.3 minutes.
- Profile context: `charm_pin_pullback_long` produced 34 trades, PnL 1237.70, 0 slow >=12h trades, and 18.0% of total PnL.
- Entry state: setup=61.99, ES-VWAP=26.20, VWAP slope=0.0431, VWAP acceleration=-0.0150, RSI=42.42, ADX=17.95, structure score=4.00, higher-low=0.2500, higher-high=3.75, pullback-from-high=9.75, rolling-high distance=14.75.
- Guard state: setup allowed=`True`, entry veto allowed=`True`, veto points=4.00, slow-risk points=0.00.
- Existing warning reason: ES pullback from high 9.75 >= 5.00; RSI slope -3.8597 <= -2.0000; ADX 17.95 <= 18.00; RSI 42.42 <= 45.00.
- Strategy selection reason: positive gamma/charm pin pullback: expectedMovePosition=0.0105, netCharm30m=-25173027, lowerFade=False, pullback=True, dynamicMaxVwapDistance=17.83.
- Intratrade path: path MFE 2.50, path MAE -28.50, MFE before MAE=`False`, TP reached=`True`.
- Surgical setup floor check: `setup_quality_score >= 62` would block this trade, keep 49 trades, retain 43.0% PnL, and leave worst MAE -375.70. It would block 56 trades total.
- No single candidate threshold in the report cleanly removes this tail; the closest visible guard is setup quality 61.99.

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
| `es_structure_rising_vwap != "False"` | 20 | 6 | 12 | 87 | 5625.80 | 1235.20 | 82.0% | -527.00 | 12751.4 |
| `long_strategy != "breakout_long_1dte"` | 20 | 6 | 14 | 85 | 5562.30 | 1298.70 | 81.1% | -527.00 | 12728.1 |
| `strategy_profile != "breakout_long_1dte"` | 20 | 6 | 14 | 85 | 5562.30 | 1298.70 | 81.1% | -527.00 | 12728.1 |
| `path_half_tp_touch_minutes >= 0.183333` | 20 | 12 | 22 | 71 | 5153.60 | 1707.40 | 75.1% | -527.00 | 499.7 |
| `option_strike_map_target_1_strike >= 7475` | 20 | 5 | 9 | 91 | 5992.30 | 868.70 | 87.3% | -403.20 | 180.1 |
| `option_strike_map_underlying_price >= 7443.25` | 20 | 4 | 9 | 92 | 6033.10 | 827.90 | 87.9% | -403.20 | 117.5 |
| `option_strike_map_target_1_strike >= 7500` | 20 | 6 | 25 | 74 | 5375.20 | 1485.80 | 78.3% | -403.20 | 115.1 |
| `path_first_observed_seconds >= 2` | 20 | 5 | 16 | 84 | 5675.20 | 1185.80 | 82.7% | -527.00 | 112.6 |
| `es_structure_higher_low_distance >= -1` | 20 | 5 | 19 | 81 | 5534.90 | 1326.10 | 80.7% | -527.00 | 82.8 |
| `path_first_observed_points >= -0.55` | 20 | 4 | 12 | 89 | 5858.50 | 1002.50 | 85.4% | -403.20 | 81.5 |
| `path_first_nonzero_move_points >= -0.55` | 20 | 4 | 12 | 89 | 5858.50 | 1002.50 | 85.4% | -403.20 | 81.5 |
| `option_strike_map_underlying_price >= 7492` | 20 | 6 | 30 | 69 | 5140.60 | 1720.40 | 74.9% | -403.20 | 65.3 |

## Upside TP Extension Candidates
| all | No upside TP extension candidates found. |  |  |  |  |  |  |  |  |  |  |

## Event Counts
- blocked: 36185
- position_wait: 8094
- stale_es_vwap: 4867
- trade_risk_extend_signal: 1192
- trade_risk_tighten_signal: 591
- order_event: 475
- waiting_spx_quote: 415
- entry_signal: 105

## Blocked Gate Counts
- setup_quality_allowed: 14461 (disabled=14461)
- above_vwap_confirmed: 9105 (disabled=9105)
- above_vwap: 8097 (disabled=8097)
- es_structure_allowed: 7769 (disabled=7769)
- pullback: 6575 (disabled=6575)
- momentum: 4172 (disabled=4172)
- es_vwap_max_distance_allowed: 3791 (disabled=3791)
- es_vwap_slope_allowed: 3673 (disabled=3673)
- trend_strength: 3333 (disabled=3333)
- es_vwap_acceleration_allowed: 1899 (disabled=1899)
- es_rolling_high_allowed: 495 (disabled=495)
- indicator_slope_allowed: 155 (disabled=155)

## By UTC Hour

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 13 | 12 | 728.40 | 60.70 | 100.0% | 0.4 |
| 8 | 11 | 1289.30 | 117.21 | 100.0% | 16.6 |
| 14 | 10 | 851.90 | 85.19 | 100.0% | 2.1 |
| 12 | 8 | 353.30 | 44.16 | 100.0% | 12.1 |
| 1 | 6 | 512.20 | 85.37 | 100.0% | 3.0 |
| 15 | 6 | 368.10 | 61.35 | 100.0% | 9.2 |
| 18 | 6 | 337.60 | 56.27 | 100.0% | 10.4 |
| 11 | 5 | 187.20 | 37.44 | 100.0% | 12.4 |
| 19 | 5 | 252.40 | 50.48 | 100.0% | 17.0 |
| 5 | 5 | 245.10 | 49.02 | 100.0% | 20.6 |
| 6 | 5 | 243.10 | 48.62 | 100.0% | 16.4 |
| 9 | 5 | 289.80 | 57.96 | 100.0% | 12.0 |
| 2 | 4 | 210.40 | 52.60 | 100.0% | 48.6 |
| 7 | 4 | 241.70 | 60.42 | 100.0% | 12.0 |
| 0 | 3 | 174.40 | 58.13 | 100.0% | 12.1 |
| 22 | 3 | 185.50 | 61.83 | 100.0% | 15.0 |
| 10 | 2 | 55.40 | 27.70 | 100.0% | 18.4 |
| 23 | 2 | 70.00 | 35.00 | 100.0% | 29.5 |
| 3 | 2 | 146.20 | 73.10 | 100.0% | 15.9 |
| 17 | 1 | 119.00 | 119.00 | 100.0% | 7.3 |

## By RSI Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <55 | 57 | 3396.20 | 59.58 | 100.0% | 7.2 |
| 55-60 | 18 | 1354.50 | 75.25 | 100.0% | 15.6 |
| >=75 | 9 | 766.10 | 85.12 | 100.0% | 5.8 |
| 60-65 | 8 | 391.20 | 48.90 | 100.0% | 27.6 |
| 70-75 | 8 | 411.00 | 51.38 | 100.0% | 18.7 |
| 65-70 | 5 | 542.00 | 108.40 | 100.0% | 16.4 |

## By ADX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <20 | 43 | 2867.10 | 66.68 | 100.0% | 8.8 |
| 20-25 | 22 | 1682.50 | 76.48 | 100.0% | 12.4 |
| 30-40 | 19 | 1143.40 | 60.18 | 100.0% | 12.0 |
| 25-30 | 15 | 826.60 | 55.11 | 100.0% | 12.0 |
| 40-50 | 5 | 301.80 | 60.36 | 100.0% | 12.0 |
| >=50 | 1 | 39.60 | 39.60 | 100.0% | 17.0 |

## By VIX Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| missing | 105 | 6861.00 | 65.34 | 100.0% | 12.0 |

## By ES VWAP Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.25 | 101 | 6293.90 | 62.32 | 100.0% | 12.0 |
| 0.25-0.5 | 3 | 550.10 | 183.37 | 100.0% | 9.4 |
| 0.5-1 | 1 | 17.00 | 17.00 | 100.0% | 29.9 |

## By ES VWAP Acceleration Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-0.05 | 52 | 3327.80 | 64.00 | 100.0% | 12.3 |
| -0.05-0 | 36 | 2326.60 | 64.63 | 100.0% | 7.8 |
| 0.1-0.25 | 8 | 794.30 | 99.29 | 100.0% | 14.3 |
| 0.05-0.1 | 6 | 286.20 | 47.70 | 100.0% | 20.5 |
| -0.25--0.1 | 2 | 109.10 | 54.55 | 100.0% | 26.6 |
| >=0.25 | 1 | 17.00 | 17.00 | 100.0% | 29.9 |

## By ES Rolling High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-6 | 30 | 1514.50 | 50.48 | 100.0% | 6.4 |
| 2-4 | 22 | 1222.40 | 55.56 | 100.0% | 13.9 |
| 0-1 | 19 | 1424.50 | 74.97 | 100.0% | 13.2 |
| 6-8 | 14 | 1432.20 | 102.30 | 100.0% | 10.8 |
| 8-12 | 9 | 418.60 | 46.51 | 100.0% | 14.0 |
| 1-2 | 5 | 365.20 | 73.04 | 100.0% | 16.5 |
| 12-20 | 5 | 448.60 | 89.72 | 100.0% | 6.6 |
| >=20 | 1 | 35.00 | 35.00 | 100.0% | 19.1 |

## By ES Rolling High Minutes Since

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 20-30 | 35 | 2490.50 | 71.16 | 100.0% | 8.7 |
| <1 | 21 | 1541.20 | 73.39 | 100.0% | 13.2 |
| 1-3 | 13 | 944.40 | 72.65 | 100.0% | 17.3 |
| 5-10 | 13 | 662.10 | 50.93 | 100.0% | 11.9 |
| 10-20 | 12 | 645.80 | 53.82 | 100.0% | 12.3 |
| 3-5 | 10 | 510.50 | 51.05 | 100.0% | 10.2 |
| 30-60 | 1 | 66.50 | 66.50 | 100.0% | 12.0 |

## By RSI Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| >=3 | 31 | 2305.30 | 74.36 | 100.0% | 12.0 |
| 0-1 | 20 | 1018.00 | 50.90 | 100.0% | 6.0 |
| <-3 | 10 | 449.30 | 44.93 | 100.0% | 9.3 |
| -1-0 | 9 | 609.20 | 67.69 | 100.0% | 12.0 |
| -2--1 | 8 | 524.40 | 65.55 | 100.0% | 16.6 |
| -3--2 | 8 | 323.80 | 40.48 | 100.0% | 6.8 |
| 1-2 | 7 | 488.00 | 69.71 | 100.0% | 15.0 |
| 2-3 | 6 | 701.60 | 116.93 | 100.0% | 17.8 |
| missing | 6 | 441.40 | 73.57 | 100.0% | 8.4 |

## By ADX Slope Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-1 | 37 | 2351.50 | 63.55 | 100.0% | 12.0 |
| -1-0 | 33 | 2498.40 | 75.71 | 100.0% | 12.7 |
| 1-2 | 19 | 1230.70 | 64.77 | 100.0% | 7.3 |
| -2--1 | 9 | 317.40 | 35.27 | 100.0% | 26.0 |
| missing | 6 | 441.40 | 73.57 | 100.0% | 8.4 |
| 2-3 | 1 | 21.60 | 21.60 | 100.0% | 46.6 |

## By ES Higher-Low Distance Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 2-4 | 33 | 1717.60 | 52.05 | 100.0% | 15.0 |
| 4-8 | 22 | 2281.30 | 103.70 | 100.0% | 12.0 |
| 1-2 | 20 | 1133.00 | 56.65 | 100.0% | 7.8 |
| >=8 | 13 | 833.60 | 64.12 | 100.0% | 14.0 |
| 0-0.5 | 10 | 475.20 | 47.52 | 100.0% | 4.5 |
| 0.5-1 | 7 | 420.30 | 60.04 | 100.0% | 11.9 |

## By ES Structure Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4 | 38 | 2284.50 | 60.12 | 100.0% | 12.0 |
| 3 | 35 | 2672.60 | 76.36 | 100.0% | 12.0 |
| 5 | 31 | 1869.90 | 60.32 | 100.0% | 11.9 |
| 2 | 1 | 34.00 | 34.00 | 100.0% | 12.1 |

## By ES Structure Pullback From High

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 0-2 | 45 | 3434.50 | 76.32 | 100.0% | 12.1 |
| 2-4 | 28 | 1596.70 | 57.03 | 100.0% | 11.9 |
| 4-8 | 26 | 1584.70 | 60.95 | 100.0% | 8.5 |
| 8-12 | 6 | 245.10 | 40.85 | 100.0% | 23.6 |

## By ES Structure Higher-Low Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 39 | 2766.70 | 70.94 | 100.0% | 12.1 |
| 2-4 | 18 | 664.90 | 36.94 | 100.0% | 20.6 |
| 0.5-1 | 11 | 962.50 | 87.50 | 100.0% | 3.8 |
| 4-8 | 11 | 561.00 | 51.00 | 100.0% | 9.9 |
| 1-2 | 10 | 645.20 | 64.52 | 100.0% | 11.9 |
| 0-0.5 | 8 | 578.20 | 72.28 | 100.0% | 10.8 |
| >=8 | 8 | 682.50 | 85.31 | 100.0% | 12.0 |

## By ES Structure Higher-High Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 38 | 2694.00 | 70.89 | 100.0% | 8.6 |
| 2-4 | 19 | 1342.20 | 70.64 | 100.0% | 9.4 |
| 4-8 | 16 | 1130.20 | 70.64 | 100.0% | 12.1 |
| 1-2 | 15 | 894.40 | 59.63 | 100.0% | 20.0 |
| >=8 | 7 | 302.20 | 43.17 | 100.0% | 12.1 |
| 0-0.5 | 6 | 245.10 | 40.85 | 100.0% | 19.0 |
| 0.5-1 | 4 | 252.90 | 63.23 | 100.0% | 10.4 |

## By ES Structure VWAP Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 37 | 2454.20 | 66.33 | 100.0% | 13.2 |
| >=24 | 30 | 1048.90 | 34.96 | 100.0% | 3.8 |
| 8-12 | 12 | 1423.20 | 118.60 | 100.0% | 17.8 |
| 2-4 | 8 | 590.80 | 73.85 | 100.0% | 9.3 |
| 12-16 | 7 | 426.10 | 60.87 | 100.0% | 12.0 |
| 16-24 | 6 | 662.30 | 110.38 | 100.0% | 10.7 |
| 0-2 | 5 | 255.50 | 51.10 | 100.0% | 12.4 |

## By Setup Quality Score

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 50-60 | 34 | 2395.90 | 70.47 | 100.0% | 7.5 |
| 60-70 | 25 | 1370.30 | 54.81 | 100.0% | 12.0 |
| 70-80 | 19 | 1327.70 | 69.88 | 100.0% | 12.0 |
| 40-50 | 17 | 1253.20 | 73.72 | 100.0% | 12.7 |
| 80-90 | 10 | 513.90 | 51.39 | 100.0% | 15.8 |

## By Entry-Veto Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 3-4 | 24 | 1473.60 | 61.40 | 100.0% | 12.0 |
| 1-2 | 21 | 1406.20 | 66.96 | 100.0% | 12.0 |
| 2-3 | 21 | 922.40 | 43.92 | 100.0% | 15.6 |
| 4-5 | 16 | 1526.60 | 95.41 | 100.0% | 10.7 |
| 5-6 | 14 | 794.30 | 56.74 | 100.0% | 7.2 |
| <1 | 9 | 737.90 | 81.99 | 100.0% | 12.0 |

## By Slow-Risk Points

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <1 | 105 | 6861.00 | 65.34 | 100.0% | 12.0 |

## By Entry Risk Tier

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| standard | 105 | 6861.00 | 65.34 | 100.0% | 12.0 |

## By ES Reclaim Current Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 4-8 | 37 | 2454.20 | 66.33 | 100.0% | 13.2 |
| >=24 | 30 | 1048.90 | 34.96 | 100.0% | 3.8 |
| 8-12 | 12 | 1423.20 | 118.60 | 100.0% | 17.8 |
| 2-4 | 8 | 590.80 | 73.85 | 100.0% | 9.3 |
| 12-16 | 7 | 426.10 | 60.87 | 100.0% | 12.0 |
| 16-24 | 6 | 662.30 | 110.38 | 100.0% | 10.7 |
| 0-2 | 5 | 255.50 | 51.10 | 100.0% | 12.4 |

## By SPX EMA20 Distance

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| <0 | 70 | 4184.70 | 59.78 | 100.0% | 8.8 |
| 2-4 | 13 | 1188.30 | 91.41 | 100.0% | 24.9 |
| 4-6 | 8 | 582.50 | 72.81 | 100.0% | 10.9 |
| 1-2 | 4 | 142.00 | 35.50 | 100.0% | 54.7 |
| 8-12 | 4 | 442.70 | 110.67 | 100.0% | 12.0 |
| >=12 | 3 | 159.80 | 53.27 | 100.0% | 16.0 |
| 6-8 | 2 | 70.00 | 35.00 | 100.0% | 40.7 |
| 0-1 | 1 | 91.00 | 91.00 | 100.0% | 12.0 |

## By Hold-Time Bucket

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| 5-15 | 37 | 3242.80 | 87.64 | 100.0% | 9.9 |
| 15-30 | 27 | 852.30 | 31.57 | 100.0% | 19.1 |
| <5 | 27 | 1880.80 | 69.66 | 100.0% | 1.2 |
| 30-60 | 7 | 207.10 | 29.59 | 100.0% | 38.0 |
| 60-180 | 6 | 228.00 | 38.00 | 100.0% | 101.3 |
| 180-720 | 1 | 450.00 | 450.00 | 100.0% | 198.3 |

## By VIX Regime

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| disabled | 105 | 6861.00 | 65.34 | 100.0% | 12.0 |

## By Option Data State

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 81 | 5439.90 | 67.16 | 100.0% | 12.0 |
| VALID_1DTE_ONLY | 20 | 1298.70 | 64.93 | 100.0% | 14.1 |
| STALE_0DTE | 4 | 122.40 | 30.60 | 100.0% | 27.2 |

## By Active Profile Set

| Group | Trades | PnL | Avg PnL | Win Rate | Median Hold Min |
| --- | ---: | ---: | ---: | ---: | ---: |
| VALID_0DTE | 81 | 5439.90 | 67.16 | 100.0% | 12.0 |
| VALID_1DTE_ONLY | 20 | 1298.70 | 64.93 | 100.0% | 14.1 |
| STALE_0DTE | 4 | 122.40 | 30.60 | 100.0% | 27.2 |

## Monthly Summary

| Month | Trades | PnL | Avg PnL | Median Hold Min | Exposure Hours | PnL/Exposure Hour | Slow >=12h |
| --- | ---: | ---: | ---: | ---: | ---: | ---: | ---: |
| 2026-06 | 67 | 4090.30 | 61.05 | 9.9 | 16.2 | 253.24 | 0 |
| 2026-07 | 38 | 2770.70 | 72.91 | 14.4 | 18.8 | 147.29 | 0 |

## TP Target Distribution

| Target | Trades | PnL | Avg PnL | Median Hold Min |
| --- | ---: | ---: | ---: | ---: |
| 2.34 | 1 | 84.00 | 84.00 | 3.0 |
| 2.40 | 34 | 1237.70 | 36.40 | 5.3 |
| 2.49 | 1 | 45.50 | 45.50 | 20.6 |
| 2.57 | 1 | 93.60 | 93.60 | 5.3 |
| 2.63 | 1 | 39.60 | 39.60 | 12.0 |
| 2.99 | 1 | 105.00 | 105.00 | 8.5 |
| 3.00 | 20 | 1298.70 | 64.93 | 14.1 |
| 3.02 | 2 | 147.60 | 73.80 | 49.9 |
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
| 3.48 | 1 | 122.50 | 122.50 | 5.8 |
| 3.51 | 1 | 35.00 | 35.00 | 17.4 |
| 3.56 | 1 | 36.00 | 36.00 | 15.6 |
| 3.58 | 1 | 36.00 | 36.00 | 23.6 |
| 3.59 | 1 | 64.80 | 64.80 | 12.4 |
| 3.60 | 6 | 538.10 | 89.68 | 9.5 |
| 4.00 | 3 | 57.60 | 19.20 | 38.0 |
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
