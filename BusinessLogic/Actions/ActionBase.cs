using Settings.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Actions
{
    /// <summary>
    /// Интерфейс действия.
    /// </summary>
    public abstract class ActionBase<T>
    {
        /// <summary>
        /// Выполнение действия.
        /// </summary>
        /// <param name="state">Состояние игры.</param>
        /// <param name="config">Конфиг игры.</param>
        /// <param name="model">Модель.</param>
        /// <returns>Результат.</returns>
        public ActionResultBase Process(GameState state, GameConfig config, T model) { 
            try
            {
                if (!CanApply(state, config, model))
                {
                    return new ActionResultBase("Невозможно выполнить операцию.");
                }

                return ProcessCore(state, config, model);
            }
            catch (Exception e)
            {
                return new ActionResultBase(e.Message);
            }
        }

        /// <summary>
        /// Выполнение действия.
        /// </summary>
        /// <param name="state">Состояние игры.</param>
        /// <param name="config">Конфиг игры.</param>
        /// <param name="model">Модель.</param>
        /// <returns>Результат.</returns>
        protected abstract ActionResultBase ProcessCore(GameState state, GameConfig config, T model);

        /// <summary>
        /// Проверка на возможность выполнения действия.
        /// </summary>
        /// <param name="state">Состояние игры.</param>
        /// <param name="config">Конфиг игры.</param>
        /// <param name="model">Модель.</param>
        /// <returns>Результат.</returns>
        protected bool CanApply(GameState state, GameConfig config, T model) 
        {
            return true;
        }
    }
}
